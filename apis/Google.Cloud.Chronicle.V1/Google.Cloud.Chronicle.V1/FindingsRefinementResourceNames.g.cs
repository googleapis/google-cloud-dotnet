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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>FindingsRefinement</c> resource.</summary>
    public sealed partial class FindingsRefinementName : gax::IResourceName, sys::IEquatable<FindingsRefinementName>
    {
        /// <summary>The possible contents of <see cref="FindingsRefinementName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFindingsRefinement = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFindingsRefinement = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}");

        /// <summary>Creates a <see cref="FindingsRefinementName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingsRefinementName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingsRefinementName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingsRefinementName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingsRefinementName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="FindingsRefinementName"/> constructed from the provided ids.</returns>
        public static FindingsRefinementName FromProjectLocationInstanceFindingsRefinement(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            new FindingsRefinementName(ResourceNameType.ProjectLocationInstanceFindingsRefinement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), findingsRefinementId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingsRefinementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FindingsRefinementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            FormatProjectLocationInstanceFindingsRefinement(projectId, locationId, instanceId, findingsRefinementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingsRefinementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FindingsRefinementName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFindingsRefinement(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            s_projectLocationInstanceFindingsRefinement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingsRefinementName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingsRefinementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingsRefinementName"/> if successful.</returns>
        public static FindingsRefinementName Parse(string findingsRefinementName) => Parse(findingsRefinementName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingsRefinementName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingsRefinementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingsRefinementName"/> if successful.</returns>
        public static FindingsRefinementName Parse(string findingsRefinementName, bool allowUnparsed) =>
            TryParse(findingsRefinementName, allowUnparsed, out FindingsRefinementName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingsRefinementName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingsRefinementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingsRefinementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingsRefinementName, out FindingsRefinementName result) =>
            TryParse(findingsRefinementName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingsRefinementName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingsRefinementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingsRefinementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingsRefinementName, bool allowUnparsed, out FindingsRefinementName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingsRefinementName, nameof(findingsRefinementName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFindingsRefinement.TryParseName(findingsRefinementName, out resourceName))
            {
                result = FromProjectLocationInstanceFindingsRefinement(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingsRefinementName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingsRefinementName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingsRefinementId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingsRefinementId = findingsRefinementId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingsRefinementName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FindingsRefinementName(string projectId, string locationId, string instanceId, string findingsRefinementId) : this(ResourceNameType.ProjectLocationInstanceFindingsRefinement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), findingsRefinementId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)))
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
        /// The <c>FindingsRefinement</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string FindingsRefinementId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFindingsRefinement: return s_projectLocationInstanceFindingsRefinement.Expand(ProjectId, LocationId, InstanceId, FindingsRefinementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingsRefinementName);

        /// <inheritdoc/>
        public bool Equals(FindingsRefinementName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FindingsRefinementName a, FindingsRefinementName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FindingsRefinementName a, FindingsRefinementName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FindingsRefinementDeployment</c> resource.</summary>
    public sealed partial class FindingsRefinementDeploymentName : gax::IResourceName, sys::IEquatable<FindingsRefinementDeploymentName>
    {
        /// <summary>The possible contents of <see cref="FindingsRefinementDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFindingsRefinement = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFindingsRefinement = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment");

        /// <summary>
        /// Creates a <see cref="FindingsRefinementDeploymentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingsRefinementDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingsRefinementDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingsRefinementDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingsRefinementDeploymentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FindingsRefinementDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static FindingsRefinementDeploymentName FromProjectLocationInstanceFindingsRefinement(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            new FindingsRefinementDeploymentName(ResourceNameType.ProjectLocationInstanceFindingsRefinement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), findingsRefinementId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingsRefinementDeploymentName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FindingsRefinementDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            FormatProjectLocationInstanceFindingsRefinement(projectId, locationId, instanceId, findingsRefinementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingsRefinementDeploymentName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FindingsRefinementDeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFindingsRefinement(string projectId, string locationId, string instanceId, string findingsRefinementId) =>
            s_projectLocationInstanceFindingsRefinement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingsRefinementDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingsRefinementDeploymentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FindingsRefinementDeploymentName"/> if successful.</returns>
        public static FindingsRefinementDeploymentName Parse(string findingsRefinementDeploymentName) =>
            Parse(findingsRefinementDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingsRefinementDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingsRefinementDeploymentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingsRefinementDeploymentName"/> if successful.</returns>
        public static FindingsRefinementDeploymentName Parse(string findingsRefinementDeploymentName, bool allowUnparsed) =>
            TryParse(findingsRefinementDeploymentName, allowUnparsed, out FindingsRefinementDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingsRefinementDeploymentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="findingsRefinementDeploymentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingsRefinementDeploymentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingsRefinementDeploymentName, out FindingsRefinementDeploymentName result) =>
            TryParse(findingsRefinementDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingsRefinementDeploymentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingsRefinementDeploymentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingsRefinementDeploymentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingsRefinementDeploymentName, bool allowUnparsed, out FindingsRefinementDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingsRefinementDeploymentName, nameof(findingsRefinementDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFindingsRefinement.TryParseName(findingsRefinementDeploymentName, out resourceName))
            {
                result = FromProjectLocationInstanceFindingsRefinement(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingsRefinementDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingsRefinementDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingsRefinementId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingsRefinementId = findingsRefinementId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingsRefinementDeploymentName"/> class from the component parts
        /// of pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/findingsRefinements/{findings_refinement}/deployment</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingsRefinementId">
        /// The <c>FindingsRefinement</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FindingsRefinementDeploymentName(string projectId, string locationId, string instanceId, string findingsRefinementId) : this(ResourceNameType.ProjectLocationInstanceFindingsRefinement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), findingsRefinementId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingsRefinementId, nameof(findingsRefinementId)))
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
        /// The <c>FindingsRefinement</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string FindingsRefinementId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFindingsRefinement: return s_projectLocationInstanceFindingsRefinement.Expand(ProjectId, LocationId, InstanceId, FindingsRefinementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingsRefinementDeploymentName);

        /// <inheritdoc/>
        public bool Equals(FindingsRefinementDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FindingsRefinementDeploymentName a, FindingsRefinementDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FindingsRefinementDeploymentName a, FindingsRefinementDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CuratedRuleSet</c> resource.</summary>
    public sealed partial class CuratedRuleSetName : gax::IResourceName, sys::IEquatable<CuratedRuleSetName>
    {
        /// <summary>The possible contents of <see cref="CuratedRuleSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceCategoryRuleSet = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceCategoryRuleSet = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}");

        /// <summary>Creates a <see cref="CuratedRuleSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CuratedRuleSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CuratedRuleSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CuratedRuleSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CuratedRuleSetName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleSetId">The <c>RuleSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CuratedRuleSetName"/> constructed from the provided ids.</returns>
        public static CuratedRuleSetName FromProjectLocationInstanceCategoryRuleSet(string projectId, string locationId, string instanceId, string categoryId, string ruleSetId) =>
            new CuratedRuleSetName(ResourceNameType.ProjectLocationInstanceCategoryRuleSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)), ruleSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleSetId, nameof(ruleSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CuratedRuleSetName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleSetId">The <c>RuleSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CuratedRuleSetName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string categoryId, string ruleSetId) =>
            FormatProjectLocationInstanceCategoryRuleSet(projectId, locationId, instanceId, categoryId, ruleSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CuratedRuleSetName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleSetId">The <c>RuleSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CuratedRuleSetName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceCategoryRuleSet(string projectId, string locationId, string instanceId, string categoryId, string ruleSetId) =>
            s_projectLocationInstanceCategoryRuleSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ruleSetId, nameof(ruleSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CuratedRuleSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="curatedRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CuratedRuleSetName"/> if successful.</returns>
        public static CuratedRuleSetName Parse(string curatedRuleSetName) => Parse(curatedRuleSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CuratedRuleSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="curatedRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CuratedRuleSetName"/> if successful.</returns>
        public static CuratedRuleSetName Parse(string curatedRuleSetName, bool allowUnparsed) =>
            TryParse(curatedRuleSetName, allowUnparsed, out CuratedRuleSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CuratedRuleSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="curatedRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CuratedRuleSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string curatedRuleSetName, out CuratedRuleSetName result) =>
            TryParse(curatedRuleSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CuratedRuleSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="curatedRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CuratedRuleSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string curatedRuleSetName, bool allowUnparsed, out CuratedRuleSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(curatedRuleSetName, nameof(curatedRuleSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceCategoryRuleSet.TryParseName(curatedRuleSetName, out resourceName))
            {
                result = FromProjectLocationInstanceCategoryRuleSet(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(curatedRuleSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CuratedRuleSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string categoryId = null, string instanceId = null, string locationId = null, string projectId = null, string ruleSetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CategoryId = categoryId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            RuleSetId = ruleSetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CuratedRuleSetName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/curatedRuleSetCategories/{category}/curatedRuleSets/{rule_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ruleSetId">The <c>RuleSet</c> ID. Must not be <c>null</c> or empty.</param>
        public CuratedRuleSetName(string projectId, string locationId, string instanceId, string categoryId, string ruleSetId) : this(ResourceNameType.ProjectLocationInstanceCategoryRuleSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)), ruleSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(ruleSetId, nameof(ruleSetId)))
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
        /// The <c>Category</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CategoryId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RuleSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RuleSetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInstanceCategoryRuleSet: return s_projectLocationInstanceCategoryRuleSet.Expand(ProjectId, LocationId, InstanceId, CategoryId, RuleSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CuratedRuleSetName);

        /// <inheritdoc/>
        public bool Equals(CuratedRuleSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CuratedRuleSetName a, CuratedRuleSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CuratedRuleSetName a, CuratedRuleSetName b) => !(a == b);
    }

    public partial class FindingsRefinement
    {
        /// <summary>
        /// <see cref="gccv::FindingsRefinementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FindingsRefinementName FindingsRefinementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingsRefinementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FindingsRefinementDeployment
    {
        /// <summary>
        /// <see cref="gccv::FindingsRefinementDeploymentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FindingsRefinementDeploymentName FindingsRefinementDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingsRefinementDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DetectionExclusionApplication
    {
        /// <summary>
        /// <see cref="CuratedRuleSetName"/>-typed view over the <see cref="CuratedRuleSets"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CuratedRuleSetName> CuratedRuleSetsAsCuratedRuleSetNames
        {
            get => new gax::ResourceNameList<CuratedRuleSetName>(CuratedRuleSets, s => string.IsNullOrEmpty(s) ? null : CuratedRuleSetName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CuratedRuleName"/>-typed view over the <see cref="CuratedRules"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CuratedRuleName> CuratedRulesAsCuratedRuleNames
        {
            get => new gax::ResourceNameList<CuratedRuleName>(CuratedRules, s => string.IsNullOrEmpty(s) ? null : CuratedRuleName.Parse(s, allowUnparsed: true));
        }

        /// <summary><see cref="RuleName"/>-typed view over the <see cref="Rules"/> resource name property.</summary>
        public gax::ResourceNameList<RuleName> RulesAsRuleNames
        {
            get => new gax::ResourceNameList<RuleName>(Rules, s => string.IsNullOrEmpty(s) ? null : RuleName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CuratedRuleSetName"/>-typed view over the <see cref="DeletedCuratedRuleSets"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<CuratedRuleSetName> DeletedCuratedRuleSetsAsCuratedRuleSetNames
        {
            get => new gax::ResourceNameList<CuratedRuleSetName>(DeletedCuratedRuleSets, s => string.IsNullOrEmpty(s) ? null : CuratedRuleSetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class FindingsRefinementActivity
    {
        /// <summary>
        /// <see cref="FindingsRefinementName"/>-typed view over the <see cref="FindingsRefinement"/> resource name
        /// property.
        /// </summary>
        public FindingsRefinementName FindingsRefinementAsFindingsRefinementName
        {
            get => string.IsNullOrEmpty(FindingsRefinement) ? null : FindingsRefinementName.Parse(FindingsRefinement, allowUnparsed: true);
            set => FindingsRefinement = value?.ToString() ?? "";
        }
    }

    public partial class DetectionExclusionActivity
    {
        public partial class Types
        {
            public partial class DetectionExclusionDetectorActivity
            {
                /// <summary>
                /// <see cref="CuratedRuleName"/>-typed view over the <see cref="CuratedRule"/> resource name property.
                /// </summary>
                public CuratedRuleName CuratedRuleAsCuratedRuleName
                {
                    get => string.IsNullOrEmpty(CuratedRule) ? null : CuratedRuleName.Parse(CuratedRule, allowUnparsed: true);
                    set => CuratedRule = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="CuratedRuleSetName"/>-typed view over the <see cref="CuratedRuleSet"/> resource name
                /// property.
                /// </summary>
                public CuratedRuleSetName CuratedRuleSetAsCuratedRuleSetName
                {
                    get => string.IsNullOrEmpty(CuratedRuleSet) ? null : CuratedRuleSetName.Parse(CuratedRuleSet, allowUnparsed: true);
                    set => CuratedRuleSet = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="RuleName"/>-typed view over the <see cref="Rule"/> resource name property.
                /// </summary>
                public RuleName RuleAsRuleName
                {
                    get => string.IsNullOrEmpty(Rule) ? null : RuleName.Parse(Rule, allowUnparsed: true);
                    set => Rule = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="CuratedRuleSetName"/>-typed view over the <see cref="DeletedCuratedRuleSet"/> resource
                /// name property.
                /// </summary>
                public CuratedRuleSetName DeletedCuratedRuleSetAsCuratedRuleSetName
                {
                    get => string.IsNullOrEmpty(DeletedCuratedRuleSet) ? null : CuratedRuleSetName.Parse(DeletedCuratedRuleSet, allowUnparsed: true);
                    set => DeletedCuratedRuleSet = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class GetFindingsRefinementRequest
    {
        /// <summary>
        /// <see cref="gccv::FindingsRefinementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FindingsRefinementName FindingsRefinementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingsRefinementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFindingsRefinementsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateFindingsRefinementRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFindingsRefinementDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::FindingsRefinementDeploymentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FindingsRefinementDeploymentName FindingsRefinementDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingsRefinementDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAllFindingsRefinementDeploymentsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public InstanceName InstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : InstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }
    }

    public partial class ComputeFindingsRefinementActivityRequest
    {
        /// <summary>
        /// <see cref="gccv::FindingsRefinementName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FindingsRefinementName FindingsRefinementName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FindingsRefinementName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ComputeAllFindingsRefinementActivitiesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public InstanceName InstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : InstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }
    }
}
