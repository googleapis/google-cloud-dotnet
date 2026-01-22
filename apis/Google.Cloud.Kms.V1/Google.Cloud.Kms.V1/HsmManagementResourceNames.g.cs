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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gckv = Google.Cloud.Kms.V1;
using sys = System;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Resource name for the <c>SingleTenantHsmInstance</c> resource.</summary>
    public sealed partial class SingleTenantHsmInstanceName : gax::IResourceName, sys::IEquatable<SingleTenantHsmInstanceName>
    {
        /// <summary>The possible contents of <see cref="SingleTenantHsmInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>.
            /// </summary>
            ProjectLocationSingleTenantHsmInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationSingleTenantHsmInstance = new gax::PathTemplate("projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}");

        /// <summary>Creates a <see cref="SingleTenantHsmInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SingleTenantHsmInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SingleTenantHsmInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SingleTenantHsmInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SingleTenantHsmInstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SingleTenantHsmInstanceName"/> constructed from the provided ids.
        /// </returns>
        public static SingleTenantHsmInstanceName FromProjectLocationSingleTenantHsmInstance(string projectId, string locationId, string singleTenantHsmInstanceId) =>
            new SingleTenantHsmInstanceName(ResourceNameType.ProjectLocationSingleTenantHsmInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), singleTenantHsmInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SingleTenantHsmInstanceName"/> with
        /// pattern <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SingleTenantHsmInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string singleTenantHsmInstanceId) =>
            FormatProjectLocationSingleTenantHsmInstance(projectId, locationId, singleTenantHsmInstanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SingleTenantHsmInstanceName"/> with
        /// pattern <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SingleTenantHsmInstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>.
        /// </returns>
        public static string FormatProjectLocationSingleTenantHsmInstance(string projectId, string locationId, string singleTenantHsmInstanceId) =>
            s_projectLocationSingleTenantHsmInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SingleTenantHsmInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="singleTenantHsmInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SingleTenantHsmInstanceName"/> if successful.</returns>
        public static SingleTenantHsmInstanceName Parse(string singleTenantHsmInstanceName) =>
            Parse(singleTenantHsmInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SingleTenantHsmInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="singleTenantHsmInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SingleTenantHsmInstanceName"/> if successful.</returns>
        public static SingleTenantHsmInstanceName Parse(string singleTenantHsmInstanceName, bool allowUnparsed) =>
            TryParse(singleTenantHsmInstanceName, allowUnparsed, out SingleTenantHsmInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SingleTenantHsmInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="singleTenantHsmInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SingleTenantHsmInstanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string singleTenantHsmInstanceName, out SingleTenantHsmInstanceName result) =>
            TryParse(singleTenantHsmInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SingleTenantHsmInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="singleTenantHsmInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SingleTenantHsmInstanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string singleTenantHsmInstanceName, bool allowUnparsed, out SingleTenantHsmInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceName, nameof(singleTenantHsmInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSingleTenantHsmInstance.TryParseName(singleTenantHsmInstanceName, out resourceName))
            {
                result = FromProjectLocationSingleTenantHsmInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(singleTenantHsmInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SingleTenantHsmInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string singleTenantHsmInstanceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SingleTenantHsmInstanceId = singleTenantHsmInstanceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SingleTenantHsmInstanceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SingleTenantHsmInstanceName(string projectId, string locationId, string singleTenantHsmInstanceId) : this(ResourceNameType.ProjectLocationSingleTenantHsmInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), singleTenantHsmInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)))
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
        /// The <c>SingleTenantHsmInstance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SingleTenantHsmInstanceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSingleTenantHsmInstance: return s_projectLocationSingleTenantHsmInstance.Expand(ProjectId, LocationId, SingleTenantHsmInstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SingleTenantHsmInstanceName);

        /// <inheritdoc/>
        public bool Equals(SingleTenantHsmInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SingleTenantHsmInstanceName a, SingleTenantHsmInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SingleTenantHsmInstanceName a, SingleTenantHsmInstanceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SingleTenantHsmInstanceProposal</c> resource.</summary>
    public sealed partial class SingleTenantHsmInstanceProposalName : gax::IResourceName, sys::IEquatable<SingleTenantHsmInstanceProposalName>
    {
        /// <summary>The possible contents of <see cref="SingleTenantHsmInstanceProposalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
            /// .
            /// </summary>
            ProjectLocationSingleTenantHsmInstanceProposal = 1,
        }

        private static gax::PathTemplate s_projectLocationSingleTenantHsmInstanceProposal = new gax::PathTemplate("projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}");

        /// <summary>
        /// Creates a <see cref="SingleTenantHsmInstanceProposalName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SingleTenantHsmInstanceProposalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SingleTenantHsmInstanceProposalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SingleTenantHsmInstanceProposalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SingleTenantHsmInstanceProposalName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SingleTenantHsmInstanceProposalName"/> constructed from the provided ids.
        /// </returns>
        public static SingleTenantHsmInstanceProposalName FromProjectLocationSingleTenantHsmInstanceProposal(string projectId, string locationId, string singleTenantHsmInstanceId, string proposalId) =>
            new SingleTenantHsmInstanceProposalName(ResourceNameType.ProjectLocationSingleTenantHsmInstanceProposal, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), singleTenantHsmInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)), proposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SingleTenantHsmInstanceProposalName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SingleTenantHsmInstanceProposalName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string singleTenantHsmInstanceId, string proposalId) =>
            FormatProjectLocationSingleTenantHsmInstanceProposal(projectId, locationId, singleTenantHsmInstanceId, proposalId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SingleTenantHsmInstanceProposalName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SingleTenantHsmInstanceProposalName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSingleTenantHsmInstanceProposal(string projectId, string locationId, string singleTenantHsmInstanceId, string proposalId) =>
            s_projectLocationSingleTenantHsmInstanceProposal.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SingleTenantHsmInstanceProposalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="singleTenantHsmInstanceProposalName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SingleTenantHsmInstanceProposalName"/> if successful.</returns>
        public static SingleTenantHsmInstanceProposalName Parse(string singleTenantHsmInstanceProposalName) =>
            Parse(singleTenantHsmInstanceProposalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SingleTenantHsmInstanceProposalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="singleTenantHsmInstanceProposalName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SingleTenantHsmInstanceProposalName"/> if successful.</returns>
        public static SingleTenantHsmInstanceProposalName Parse(string singleTenantHsmInstanceProposalName, bool allowUnparsed) =>
            TryParse(singleTenantHsmInstanceProposalName, allowUnparsed, out SingleTenantHsmInstanceProposalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SingleTenantHsmInstanceProposalName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="singleTenantHsmInstanceProposalName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SingleTenantHsmInstanceProposalName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string singleTenantHsmInstanceProposalName, out SingleTenantHsmInstanceProposalName result) =>
            TryParse(singleTenantHsmInstanceProposalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SingleTenantHsmInstanceProposalName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="singleTenantHsmInstanceProposalName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SingleTenantHsmInstanceProposalName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string singleTenantHsmInstanceProposalName, bool allowUnparsed, out SingleTenantHsmInstanceProposalName result)
        {
            gax::GaxPreconditions.CheckNotNull(singleTenantHsmInstanceProposalName, nameof(singleTenantHsmInstanceProposalName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSingleTenantHsmInstanceProposal.TryParseName(singleTenantHsmInstanceProposalName, out resourceName))
            {
                result = FromProjectLocationSingleTenantHsmInstanceProposal(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(singleTenantHsmInstanceProposalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SingleTenantHsmInstanceProposalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string proposalId = null, string singleTenantHsmInstanceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ProposalId = proposalId;
            SingleTenantHsmInstanceId = singleTenantHsmInstanceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SingleTenantHsmInstanceProposalName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/singleTenantHsmInstances/{single_tenant_hsm_instance}/proposals/{proposal}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="singleTenantHsmInstanceId">
        /// The <c>SingleTenantHsmInstance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="proposalId">The <c>Proposal</c> ID. Must not be <c>null</c> or empty.</param>
        public SingleTenantHsmInstanceProposalName(string projectId, string locationId, string singleTenantHsmInstanceId, string proposalId) : this(ResourceNameType.ProjectLocationSingleTenantHsmInstanceProposal, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), singleTenantHsmInstanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(singleTenantHsmInstanceId, nameof(singleTenantHsmInstanceId)), proposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(proposalId, nameof(proposalId)))
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
        /// The <c>Proposal</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProposalId { get; }

        /// <summary>
        /// The <c>SingleTenantHsmInstance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SingleTenantHsmInstanceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSingleTenantHsmInstanceProposal: return s_projectLocationSingleTenantHsmInstanceProposal.Expand(ProjectId, LocationId, SingleTenantHsmInstanceId, ProposalId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SingleTenantHsmInstanceProposalName);

        /// <inheritdoc/>
        public bool Equals(SingleTenantHsmInstanceProposalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SingleTenantHsmInstanceProposalName a, SingleTenantHsmInstanceProposalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SingleTenantHsmInstanceProposalName a, SingleTenantHsmInstanceProposalName b) => !(a == b);
    }

    public partial class SingleTenantHsmInstance
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceName SingleTenantHsmInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SingleTenantHsmInstanceProposal
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceProposalName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceProposalName SingleTenantHsmInstanceProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSingleTenantHsmInstancesRequest
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

    public partial class GetSingleTenantHsmInstanceRequest
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceName SingleTenantHsmInstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSingleTenantHsmInstanceRequest
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

    public partial class CreateSingleTenantHsmInstanceProposalRequest
    {
        /// <summary>
        /// <see cref="SingleTenantHsmInstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SingleTenantHsmInstanceName ParentAsSingleTenantHsmInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SingleTenantHsmInstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSingleTenantHsmInstanceProposalRequest
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceProposalName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceProposalName SingleTenantHsmInstanceProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApproveSingleTenantHsmInstanceProposalRequest
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceProposalName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceProposalName SingleTenantHsmInstanceProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteSingleTenantHsmInstanceProposalRequest
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceProposalName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceProposalName SingleTenantHsmInstanceProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSingleTenantHsmInstanceProposalsRequest
    {
        /// <summary>
        /// <see cref="SingleTenantHsmInstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SingleTenantHsmInstanceName ParentAsSingleTenantHsmInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SingleTenantHsmInstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSingleTenantHsmInstanceProposalRequest
    {
        /// <summary>
        /// <see cref="gckv::SingleTenantHsmInstanceProposalName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gckv::SingleTenantHsmInstanceProposalName SingleTenantHsmInstanceProposalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::SingleTenantHsmInstanceProposalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
