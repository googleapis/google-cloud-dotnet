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
using gctv = Google.Cloud.TelcoAutomation.V1;
using sys = System;

namespace Google.Cloud.TelcoAutomation.V1
{
    /// <summary>Resource name for the <c>OrchestrationCluster</c> resource.</summary>
    public sealed partial class OrchestrationClusterName : gax::IResourceName, sys::IEquatable<OrchestrationClusterName>
    {
        /// <summary>The possible contents of <see cref="OrchestrationClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
            /// </summary>
            ProjectLocationOrchestrationCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationOrchestrationCluster = new gax::PathTemplate("projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}");

        /// <summary>Creates a <see cref="OrchestrationClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrchestrationClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrchestrationClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrchestrationClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrchestrationClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="OrchestrationClusterName"/> constructed from the provided ids.
        /// </returns>
        public static OrchestrationClusterName FromProjectLocationOrchestrationCluster(string projectId, string locationId, string orchestrationClusterId) =>
            new OrchestrationClusterName(ResourceNameType.ProjectLocationOrchestrationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrchestrationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrchestrationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string orchestrationClusterId) =>
            FormatProjectLocationOrchestrationCluster(projectId, locationId, orchestrationClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrchestrationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrchestrationClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationOrchestrationCluster(string projectId, string locationId, string orchestrationClusterId) =>
            s_projectLocationOrchestrationCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrchestrationClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orchestrationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrchestrationClusterName"/> if successful.</returns>
        public static OrchestrationClusterName Parse(string orchestrationClusterName) =>
            Parse(orchestrationClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrchestrationClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orchestrationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrchestrationClusterName"/> if successful.</returns>
        public static OrchestrationClusterName Parse(string orchestrationClusterName, bool allowUnparsed) =>
            TryParse(orchestrationClusterName, allowUnparsed, out OrchestrationClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrchestrationClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orchestrationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrchestrationClusterName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orchestrationClusterName, out OrchestrationClusterName result) =>
            TryParse(orchestrationClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrchestrationClusterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orchestrationClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrchestrationClusterName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orchestrationClusterName, bool allowUnparsed, out OrchestrationClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(orchestrationClusterName, nameof(orchestrationClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrchestrationCluster.TryParseName(orchestrationClusterName, out resourceName))
            {
                result = FromProjectLocationOrchestrationCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orchestrationClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrchestrationClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string orchestrationClusterId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrchestrationClusterId = orchestrationClusterId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrchestrationClusterName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OrchestrationClusterName(string projectId, string locationId, string orchestrationClusterId) : this(ResourceNameType.ProjectLocationOrchestrationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)))
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
        /// The <c>OrchestrationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrchestrationClusterId { get; }

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
                case ResourceNameType.ProjectLocationOrchestrationCluster: return s_projectLocationOrchestrationCluster.Expand(ProjectId, LocationId, OrchestrationClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrchestrationClusterName);

        /// <inheritdoc/>
        public bool Equals(OrchestrationClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrchestrationClusterName a, OrchestrationClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrchestrationClusterName a, OrchestrationClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EdgeSlm</c> resource.</summary>
    public sealed partial class EdgeSlmName : gax::IResourceName, sys::IEquatable<EdgeSlmName>
    {
        /// <summary>The possible contents of <see cref="EdgeSlmName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
            /// </summary>
            ProjectLocationEdgeSlm = 1,
        }

        private static gax::PathTemplate s_projectLocationEdgeSlm = new gax::PathTemplate("projects/{project}/locations/{location}/edgeSlms/{edge_slm}");

        /// <summary>Creates a <see cref="EdgeSlmName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EdgeSlmName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EdgeSlmName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EdgeSlmName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EdgeSlmName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="edgeSlmId">The <c>EdgeSlm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EdgeSlmName"/> constructed from the provided ids.</returns>
        public static EdgeSlmName FromProjectLocationEdgeSlm(string projectId, string locationId, string edgeSlmId) =>
            new EdgeSlmName(ResourceNameType.ProjectLocationEdgeSlm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), edgeSlmId: gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EdgeSlmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="edgeSlmId">The <c>EdgeSlm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EdgeSlmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string edgeSlmId) =>
            FormatProjectLocationEdgeSlm(projectId, locationId, edgeSlmId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EdgeSlmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="edgeSlmId">The <c>EdgeSlm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EdgeSlmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>.
        /// </returns>
        public static string FormatProjectLocationEdgeSlm(string projectId, string locationId, string edgeSlmId) =>
            s_projectLocationEdgeSlm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)));

        /// <summary>Parses the given resource name string into a new <see cref="EdgeSlmName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="edgeSlmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EdgeSlmName"/> if successful.</returns>
        public static EdgeSlmName Parse(string edgeSlmName) => Parse(edgeSlmName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EdgeSlmName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="edgeSlmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EdgeSlmName"/> if successful.</returns>
        public static EdgeSlmName Parse(string edgeSlmName, bool allowUnparsed) =>
            TryParse(edgeSlmName, allowUnparsed, out EdgeSlmName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EdgeSlmName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="edgeSlmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EdgeSlmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string edgeSlmName, out EdgeSlmName result) => TryParse(edgeSlmName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EdgeSlmName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="edgeSlmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EdgeSlmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string edgeSlmName, bool allowUnparsed, out EdgeSlmName result)
        {
            gax::GaxPreconditions.CheckNotNull(edgeSlmName, nameof(edgeSlmName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEdgeSlm.TryParseName(edgeSlmName, out resourceName))
            {
                result = FromProjectLocationEdgeSlm(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(edgeSlmName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EdgeSlmName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string edgeSlmId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EdgeSlmId = edgeSlmId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EdgeSlmName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/edgeSlms/{edge_slm}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="edgeSlmId">The <c>EdgeSlm</c> ID. Must not be <c>null</c> or empty.</param>
        public EdgeSlmName(string projectId, string locationId, string edgeSlmId) : this(ResourceNameType.ProjectLocationEdgeSlm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), edgeSlmId: gax::GaxPreconditions.CheckNotNullOrEmpty(edgeSlmId, nameof(edgeSlmId)))
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
        /// The <c>EdgeSlm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EdgeSlmId { get; }

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
                case ResourceNameType.ProjectLocationEdgeSlm: return s_projectLocationEdgeSlm.Expand(ProjectId, LocationId, EdgeSlmId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EdgeSlmName);

        /// <inheritdoc/>
        public bool Equals(EdgeSlmName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EdgeSlmName a, EdgeSlmName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EdgeSlmName a, EdgeSlmName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Blueprint</c> resource.</summary>
    public sealed partial class BlueprintName : gax::IResourceName, sys::IEquatable<BlueprintName>
    {
        /// <summary>The possible contents of <see cref="BlueprintName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
            /// .
            /// </summary>
            ProjectLocationOrchestrationClusterBlueprint = 1,
        }

        private static gax::PathTemplate s_projectLocationOrchestrationClusterBlueprint = new gax::PathTemplate("projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}");

        /// <summary>Creates a <see cref="BlueprintName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BlueprintName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BlueprintName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BlueprintName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BlueprintName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="blueprintId">The <c>Blueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BlueprintName"/> constructed from the provided ids.</returns>
        public static BlueprintName FromProjectLocationOrchestrationClusterBlueprint(string projectId, string locationId, string orchestrationClusterId, string blueprintId) =>
            new BlueprintName(ResourceNameType.ProjectLocationOrchestrationClusterBlueprint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), blueprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(blueprintId, nameof(blueprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BlueprintName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="blueprintId">The <c>Blueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BlueprintName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string orchestrationClusterId, string blueprintId) =>
            FormatProjectLocationOrchestrationClusterBlueprint(projectId, locationId, orchestrationClusterId, blueprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BlueprintName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="blueprintId">The <c>Blueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BlueprintName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationOrchestrationClusterBlueprint(string projectId, string locationId, string orchestrationClusterId, string blueprintId) =>
            s_projectLocationOrchestrationClusterBlueprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(blueprintId, nameof(blueprintId)));

        /// <summary>Parses the given resource name string into a new <see cref="BlueprintName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="blueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BlueprintName"/> if successful.</returns>
        public static BlueprintName Parse(string blueprintName) => Parse(blueprintName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BlueprintName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="blueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BlueprintName"/> if successful.</returns>
        public static BlueprintName Parse(string blueprintName, bool allowUnparsed) =>
            TryParse(blueprintName, allowUnparsed, out BlueprintName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BlueprintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="blueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BlueprintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string blueprintName, out BlueprintName result) => TryParse(blueprintName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BlueprintName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="blueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BlueprintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string blueprintName, bool allowUnparsed, out BlueprintName result)
        {
            gax::GaxPreconditions.CheckNotNull(blueprintName, nameof(blueprintName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrchestrationClusterBlueprint.TryParseName(blueprintName, out resourceName))
            {
                result = FromProjectLocationOrchestrationClusterBlueprint(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(blueprintName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BlueprintName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string blueprintId = null, string locationId = null, string orchestrationClusterId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BlueprintId = blueprintId;
            LocationId = locationId;
            OrchestrationClusterId = orchestrationClusterId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BlueprintName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/blueprints/{blueprint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="blueprintId">The <c>Blueprint</c> ID. Must not be <c>null</c> or empty.</param>
        public BlueprintName(string projectId, string locationId, string orchestrationClusterId, string blueprintId) : this(ResourceNameType.ProjectLocationOrchestrationClusterBlueprint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), blueprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(blueprintId, nameof(blueprintId)))
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
        /// The <c>Blueprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BlueprintId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>OrchestrationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrchestrationClusterId { get; }

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
                case ResourceNameType.ProjectLocationOrchestrationClusterBlueprint: return s_projectLocationOrchestrationClusterBlueprint.Expand(ProjectId, LocationId, OrchestrationClusterId, BlueprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BlueprintName);

        /// <inheritdoc/>
        public bool Equals(BlueprintName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BlueprintName a, BlueprintName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BlueprintName a, BlueprintName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PublicBlueprint</c> resource.</summary>
    public sealed partial class PublicBlueprintName : gax::IResourceName, sys::IEquatable<PublicBlueprintName>
    {
        /// <summary>The possible contents of <see cref="PublicBlueprintName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
            /// </summary>
            ProjectLocationPublicLueprint = 1,
        }

        private static gax::PathTemplate s_projectLocationPublicLueprint = new gax::PathTemplate("projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}");

        /// <summary>Creates a <see cref="PublicBlueprintName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PublicBlueprintName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PublicBlueprintName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PublicBlueprintName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PublicBlueprintName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicLueprintId">The <c>PublicLueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PublicBlueprintName"/> constructed from the provided ids.</returns>
        public static PublicBlueprintName FromProjectLocationPublicLueprint(string projectId, string locationId, string publicLueprintId) =>
            new PublicBlueprintName(ResourceNameType.ProjectLocationPublicLueprint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publicLueprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(publicLueprintId, nameof(publicLueprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublicBlueprintName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicLueprintId">The <c>PublicLueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublicBlueprintName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string publicLueprintId) =>
            FormatProjectLocationPublicLueprint(projectId, locationId, publicLueprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublicBlueprintName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicLueprintId">The <c>PublicLueprint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublicBlueprintName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>.
        /// </returns>
        public static string FormatProjectLocationPublicLueprint(string projectId, string locationId, string publicLueprintId) =>
            s_projectLocationPublicLueprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(publicLueprintId, nameof(publicLueprintId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublicBlueprintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publicBlueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PublicBlueprintName"/> if successful.</returns>
        public static PublicBlueprintName Parse(string publicBlueprintName) => Parse(publicBlueprintName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublicBlueprintName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publicBlueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PublicBlueprintName"/> if successful.</returns>
        public static PublicBlueprintName Parse(string publicBlueprintName, bool allowUnparsed) =>
            TryParse(publicBlueprintName, allowUnparsed, out PublicBlueprintName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublicBlueprintName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publicBlueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublicBlueprintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publicBlueprintName, out PublicBlueprintName result) =>
            TryParse(publicBlueprintName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublicBlueprintName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publicBlueprintName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublicBlueprintName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publicBlueprintName, bool allowUnparsed, out PublicBlueprintName result)
        {
            gax::GaxPreconditions.CheckNotNull(publicBlueprintName, nameof(publicBlueprintName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPublicLueprint.TryParseName(publicBlueprintName, out resourceName))
            {
                result = FromProjectLocationPublicLueprint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(publicBlueprintName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PublicBlueprintName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string publicLueprintId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            PublicLueprintId = publicLueprintId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PublicBlueprintName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/publicBlueprints/{public_lueprint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publicLueprintId">The <c>PublicLueprint</c> ID. Must not be <c>null</c> or empty.</param>
        public PublicBlueprintName(string projectId, string locationId, string publicLueprintId) : this(ResourceNameType.ProjectLocationPublicLueprint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publicLueprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(publicLueprintId, nameof(publicLueprintId)))
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
        /// The <c>PublicLueprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PublicLueprintId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPublicLueprint: return s_projectLocationPublicLueprint.Expand(ProjectId, LocationId, PublicLueprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PublicBlueprintName);

        /// <inheritdoc/>
        public bool Equals(PublicBlueprintName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PublicBlueprintName a, PublicBlueprintName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PublicBlueprintName a, PublicBlueprintName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Deployment</c> resource.</summary>
    public sealed partial class DeploymentName : gax::IResourceName, sys::IEquatable<DeploymentName>
    {
        /// <summary>The possible contents of <see cref="DeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
            /// .
            /// </summary>
            ProjectLocationOrchestrationClusterDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationOrchestrationClusterDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}");

        /// <summary>Creates a <see cref="DeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeploymentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeploymentName"/> constructed from the provided ids.</returns>
        public static DeploymentName FromProjectLocationOrchestrationClusterDeployment(string projectId, string locationId, string orchestrationClusterId, string deploymentId) =>
            new DeploymentName(ResourceNameType.ProjectLocationOrchestrationClusterDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string orchestrationClusterId, string deploymentId) =>
            FormatProjectLocationOrchestrationClusterDeployment(projectId, locationId, orchestrationClusterId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationOrchestrationClusterDeployment(string projectId, string locationId, string orchestrationClusterId, string deploymentId) =>
            s_projectLocationOrchestrationClusterDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeploymentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName) => Parse(deploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeploymentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName, bool allowUnparsed) =>
            TryParse(deploymentName, allowUnparsed, out DeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, out DeploymentName result) =>
            TryParse(deploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, bool allowUnparsed, out DeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(deploymentName, nameof(deploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrchestrationClusterDeployment.TryParseName(deploymentName, out resourceName))
            {
                result = FromProjectLocationOrchestrationClusterDeployment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string locationId = null, string orchestrationClusterId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            LocationId = locationId;
            OrchestrationClusterId = orchestrationClusterId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeploymentName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public DeploymentName(string projectId, string locationId, string orchestrationClusterId, string deploymentId) : this(ResourceNameType.ProjectLocationOrchestrationClusterDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
        /// The <c>Deployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeploymentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>OrchestrationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrchestrationClusterId { get; }

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
                case ResourceNameType.ProjectLocationOrchestrationClusterDeployment: return s_projectLocationOrchestrationClusterDeployment.Expand(ProjectId, LocationId, OrchestrationClusterId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeploymentName);

        /// <inheritdoc/>
        public bool Equals(DeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeploymentName a, DeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeploymentName a, DeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>HydratedDeployment</c> resource.</summary>
    public sealed partial class HydratedDeploymentName : gax::IResourceName, sys::IEquatable<HydratedDeploymentName>
    {
        /// <summary>The possible contents of <see cref="HydratedDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
            /// .
            /// </summary>
            ProjectLocationOrchestrationClusterDeploymentHydratedDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationOrchestrationClusterDeploymentHydratedDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}");

        /// <summary>Creates a <see cref="HydratedDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HydratedDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HydratedDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HydratedDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HydratedDeploymentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hydratedDeploymentId">
        /// The <c>HydratedDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="HydratedDeploymentName"/> constructed from the provided ids.</returns>
        public static HydratedDeploymentName FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment(string projectId, string locationId, string orchestrationClusterId, string deploymentId, string hydratedDeploymentId) =>
            new HydratedDeploymentName(ResourceNameType.ProjectLocationOrchestrationClusterDeploymentHydratedDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), hydratedDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(hydratedDeploymentId, nameof(hydratedDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HydratedDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hydratedDeploymentId">
        /// The <c>HydratedDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HydratedDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string orchestrationClusterId, string deploymentId, string hydratedDeploymentId) =>
            FormatProjectLocationOrchestrationClusterDeploymentHydratedDeployment(projectId, locationId, orchestrationClusterId, deploymentId, hydratedDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HydratedDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hydratedDeploymentId">
        /// The <c>HydratedDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HydratedDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationOrchestrationClusterDeploymentHydratedDeployment(string projectId, string locationId, string orchestrationClusterId, string deploymentId, string hydratedDeploymentId) =>
            s_projectLocationOrchestrationClusterDeploymentHydratedDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hydratedDeploymentId, nameof(hydratedDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HydratedDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hydratedDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HydratedDeploymentName"/> if successful.</returns>
        public static HydratedDeploymentName Parse(string hydratedDeploymentName) => Parse(hydratedDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HydratedDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hydratedDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HydratedDeploymentName"/> if successful.</returns>
        public static HydratedDeploymentName Parse(string hydratedDeploymentName, bool allowUnparsed) =>
            TryParse(hydratedDeploymentName, allowUnparsed, out HydratedDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HydratedDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hydratedDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HydratedDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hydratedDeploymentName, out HydratedDeploymentName result) =>
            TryParse(hydratedDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HydratedDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hydratedDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HydratedDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hydratedDeploymentName, bool allowUnparsed, out HydratedDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(hydratedDeploymentName, nameof(hydratedDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOrchestrationClusterDeploymentHydratedDeployment.TryParseName(hydratedDeploymentName, out resourceName))
            {
                result = FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hydratedDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HydratedDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deploymentId = null, string hydratedDeploymentId = null, string locationId = null, string orchestrationClusterId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeploymentId = deploymentId;
            HydratedDeploymentId = hydratedDeploymentId;
            LocationId = locationId;
            OrchestrationClusterId = orchestrationClusterId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HydratedDeploymentName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/orchestrationClusters/{orchestration_cluster}/deployments/{deployment}/hydratedDeployments/{hydrated_deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orchestrationClusterId">
        /// The <c>OrchestrationCluster</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hydratedDeploymentId">
        /// The <c>HydratedDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public HydratedDeploymentName(string projectId, string locationId, string orchestrationClusterId, string deploymentId, string hydratedDeploymentId) : this(ResourceNameType.ProjectLocationOrchestrationClusterDeploymentHydratedDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orchestrationClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(orchestrationClusterId, nameof(orchestrationClusterId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)), hydratedDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(hydratedDeploymentId, nameof(hydratedDeploymentId)))
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
        /// The <c>Deployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeploymentId { get; }

        /// <summary>
        /// The <c>HydratedDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string HydratedDeploymentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>OrchestrationCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrchestrationClusterId { get; }

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
                case ResourceNameType.ProjectLocationOrchestrationClusterDeploymentHydratedDeployment: return s_projectLocationOrchestrationClusterDeploymentHydratedDeployment.Expand(ProjectId, LocationId, OrchestrationClusterId, DeploymentId, HydratedDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HydratedDeploymentName);

        /// <inheritdoc/>
        public bool Equals(HydratedDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HydratedDeploymentName a, HydratedDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HydratedDeploymentName a, HydratedDeploymentName b) => !(a == b);
    }

    public partial class OrchestrationCluster
    {
        /// <summary>
        /// <see cref="gctv::OrchestrationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::OrchestrationClusterName OrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::OrchestrationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EdgeSlm
    {
        /// <summary>
        /// <see cref="gctv::EdgeSlmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::EdgeSlmName EdgeSlmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::EdgeSlmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="OrchestrationCluster"/> resource name
        /// property.
        /// </summary>
        public OrchestrationClusterName OrchestrationClusterAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(OrchestrationCluster) ? null : OrchestrationClusterName.Parse(OrchestrationCluster, allowUnparsed: true);
            set => OrchestrationCluster = value?.ToString() ?? "";
        }
    }

    public partial class Blueprint
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PublicBlueprint
    {
        /// <summary>
        /// <see cref="gctv::PublicBlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::PublicBlueprintName PublicBlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::PublicBlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Deployment
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HydratedDeployment
    {
        /// <summary>
        /// <see cref="gctv::HydratedDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::HydratedDeploymentName HydratedDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::HydratedDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOrchestrationClustersRequest
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

    public partial class GetOrchestrationClusterRequest
    {
        /// <summary>
        /// <see cref="gctv::OrchestrationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::OrchestrationClusterName OrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::OrchestrationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOrchestrationClusterRequest
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

    public partial class DeleteOrchestrationClusterRequest
    {
        /// <summary>
        /// <see cref="gctv::OrchestrationClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::OrchestrationClusterName OrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::OrchestrationClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEdgeSlmsRequest
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

    public partial class GetEdgeSlmRequest
    {
        /// <summary>
        /// <see cref="gctv::EdgeSlmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::EdgeSlmName EdgeSlmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::EdgeSlmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEdgeSlmRequest
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

    public partial class DeleteEdgeSlmRequest
    {
        /// <summary>
        /// <see cref="gctv::EdgeSlmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::EdgeSlmName EdgeSlmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::EdgeSlmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBlueprintRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBlueprintsRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ApproveBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProposeBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RejectBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBlueprintRevisionsRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchBlueprintRevisionsRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DiscardBlueprintChangesRequest
    {
        /// <summary>
        /// <see cref="gctv::BlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::BlueprintName BlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::BlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPublicBlueprintsRequest
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

    public partial class GetPublicBlueprintRequest
    {
        /// <summary>
        /// <see cref="gctv::PublicBlueprintName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::PublicBlueprintName PublicBlueprintName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::PublicBlueprintName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeploymentRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RemoveDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeploymentsRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDeploymentRevisionsRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchDeploymentRevisionsRequest
    {
        /// <summary>
        /// <see cref="OrchestrationClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrchestrationClusterName ParentAsOrchestrationClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrchestrationClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DiscardDeploymentChangesRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApplyDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ComputeDeploymentStatusRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RollbackDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetHydratedDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::HydratedDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::HydratedDeploymentName HydratedDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::HydratedDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHydratedDeploymentsRequest
    {
        /// <summary>
        /// <see cref="DeploymentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DeploymentName ParentAsDeploymentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DeploymentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ApplyHydratedDeploymentRequest
    {
        /// <summary>
        /// <see cref="gctv::HydratedDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::HydratedDeploymentName HydratedDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::HydratedDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
