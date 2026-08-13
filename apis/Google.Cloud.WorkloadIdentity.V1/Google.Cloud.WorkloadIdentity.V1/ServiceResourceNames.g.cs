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
using gcwv = Google.Cloud.WorkloadIdentity.V1;
using sys = System;

namespace Google.Cloud.WorkloadIdentity.V1
{
    /// <summary>Resource name for the <c>ServiceAgent</c> resource.</summary>
    public sealed partial class ServiceAgentName : gax::IResourceName, sys::IEquatable<ServiceAgentName>
    {
        /// <summary>The possible contents of <see cref="ServiceAgentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
            /// .
            /// </summary>
            ProjectLocationServiceProducerServiceAgent = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
            /// .
            /// </summary>
            FolderLocationServiceProducerServiceAgent = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
            /// .
            /// </summary>
            OrganizationLocationServiceProducerServiceAgent = 3,
        }

        private static gax::PathTemplate s_projectLocationServiceProducerServiceAgent = new gax::PathTemplate("projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}");

        private static gax::PathTemplate s_folderLocationServiceProducerServiceAgent = new gax::PathTemplate("folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}");

        private static gax::PathTemplate s_organizationLocationServiceProducerServiceAgent = new gax::PathTemplate("organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}");

        /// <summary>Creates a <see cref="ServiceAgentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAgentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAgentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAgentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAgentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAgentName"/> constructed from the provided ids.</returns>
        public static ServiceAgentName FromProjectLocationServiceProducerServiceAgent(string projectId, string locationId, string serviceProducerId, string serviceAgentId) =>
            new ServiceAgentName(ResourceNameType.ProjectLocationServiceProducerServiceAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), serviceAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>
        /// Creates a <see cref="ServiceAgentName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAgentName"/> constructed from the provided ids.</returns>
        public static ServiceAgentName FromFolderLocationServiceProducerServiceAgent(string folderId, string locationId, string serviceProducerId, string serviceAgentId) =>
            new ServiceAgentName(ResourceNameType.FolderLocationServiceProducerServiceAgent, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), serviceAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>
        /// Creates a <see cref="ServiceAgentName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAgentName"/> constructed from the provided ids.</returns>
        public static ServiceAgentName FromOrganizationLocationServiceProducerServiceAgent(string organizationId, string locationId, string serviceProducerId, string serviceAgentId) =>
            new ServiceAgentName(ResourceNameType.OrganizationLocationServiceProducerServiceAgent, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), serviceAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceProducerId, string serviceAgentId) =>
            FormatProjectLocationServiceProducerServiceAgent(projectId, locationId, serviceProducerId, serviceAgentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationServiceProducerServiceAgent(string projectId, string locationId, string serviceProducerId, string serviceAgentId) =>
            s_projectLocationServiceProducerServiceAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationServiceProducerServiceAgent(string folderId, string locationId, string serviceProducerId, string serviceAgentId) =>
            s_folderLocationServiceProducerServiceAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAgentName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationServiceProducerServiceAgent(string organizationId, string locationId, string serviceProducerId, string serviceAgentId) =>
            s_organizationLocationServiceProducerServiceAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceAgentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAgentName"/> if successful.</returns>
        public static ServiceAgentName Parse(string serviceAgentName) => Parse(serviceAgentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAgentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAgentName"/> if successful.</returns>
        public static ServiceAgentName Parse(string serviceAgentName, bool allowUnparsed) =>
            TryParse(serviceAgentName, allowUnparsed, out ServiceAgentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAgentName, out ServiceAgentName result) =>
            TryParse(serviceAgentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAgentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAgentName, bool allowUnparsed, out ServiceAgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAgentName, nameof(serviceAgentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceProducerServiceAgent.TryParseName(serviceAgentName, out resourceName))
            {
                result = FromProjectLocationServiceProducerServiceAgent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationServiceProducerServiceAgent.TryParseName(serviceAgentName, out resourceName))
            {
                result = FromFolderLocationServiceProducerServiceAgent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationServiceProducerServiceAgent.TryParseName(serviceAgentName, out resourceName))
            {
                result = FromOrganizationLocationServiceProducerServiceAgent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAgentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAgentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string serviceAgentId = null, string serviceProducerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ServiceAgentId = serviceAgentId;
            ServiceProducerId = serviceProducerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAgentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}/serviceAgents/{service_agent}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAgentId">The <c>ServiceAgent</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAgentName(string projectId, string locationId, string serviceProducerId, string serviceAgentId) : this(ResourceNameType.ProjectLocationServiceProducerServiceAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)), serviceAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAgentId, nameof(serviceAgentId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ServiceAgent</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ServiceAgentId { get; }

        /// <summary>
        /// The <c>ServiceProducer</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ServiceProducerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceProducerServiceAgent: return s_projectLocationServiceProducerServiceAgent.Expand(ProjectId, LocationId, ServiceProducerId, ServiceAgentId);
                case ResourceNameType.FolderLocationServiceProducerServiceAgent: return s_folderLocationServiceProducerServiceAgent.Expand(FolderId, LocationId, ServiceProducerId, ServiceAgentId);
                case ResourceNameType.OrganizationLocationServiceProducerServiceAgent: return s_organizationLocationServiceProducerServiceAgent.Expand(OrganizationId, LocationId, ServiceProducerId, ServiceAgentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAgentName);

        /// <inheritdoc/>
        public bool Equals(ServiceAgentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAgentName a, ServiceAgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAgentName a, ServiceAgentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceProducer</c> resource.</summary>
    public sealed partial class ServiceProducerName : gax::IResourceName, sys::IEquatable<ServiceProducerName>
    {
        /// <summary>The possible contents of <see cref="ServiceProducerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
            /// </summary>
            ProjectLocationServiceProducer = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c>.
            /// </summary>
            FolderLocationServiceProducer = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>.
            /// </summary>
            OrganizationLocationServiceProducer = 3,
        }

        private static gax::PathTemplate s_projectLocationServiceProducer = new gax::PathTemplate("projects/{project}/locations/{location}/serviceProducers/{service_producer}");

        private static gax::PathTemplate s_folderLocationServiceProducer = new gax::PathTemplate("folders/{folder}/locations/{location}/serviceProducers/{service_producer}");

        private static gax::PathTemplate s_organizationLocationServiceProducer = new gax::PathTemplate("organizations/{organization}/locations/{location}/serviceProducers/{service_producer}");

        /// <summary>Creates a <see cref="ServiceProducerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceProducerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceProducerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceProducerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceProducerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceProducerName"/> constructed from the provided ids.</returns>
        public static ServiceProducerName FromProjectLocationServiceProducer(string projectId, string locationId, string serviceProducerId) =>
            new ServiceProducerName(ResourceNameType.ProjectLocationServiceProducer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Creates a <see cref="ServiceProducerName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceProducerName"/> constructed from the provided ids.</returns>
        public static ServiceProducerName FromFolderLocationServiceProducer(string folderId, string locationId, string serviceProducerId) =>
            new ServiceProducerName(ResourceNameType.FolderLocationServiceProducer, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Creates a <see cref="ServiceProducerName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceProducerName"/> constructed from the provided ids.</returns>
        public static ServiceProducerName FromOrganizationLocationServiceProducer(string organizationId, string locationId, string serviceProducerId) =>
            new ServiceProducerName(ResourceNameType.OrganizationLocationServiceProducer, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceProducerId) =>
            FormatProjectLocationServiceProducer(projectId, locationId, serviceProducerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceProducer(string projectId, string locationId, string serviceProducerId) =>
            s_projectLocationServiceProducer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </returns>
        public static string FormatFolderLocationServiceProducer(string folderId, string locationId, string serviceProducerId) =>
            s_folderLocationServiceProducer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProducerName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>.
        /// </returns>
        public static string FormatOrganizationLocationServiceProducer(string organizationId, string locationId, string serviceProducerId) =>
            s_organizationLocationServiceProducer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceProducerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceProducerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceProducerName"/> if successful.</returns>
        public static ServiceProducerName Parse(string serviceProducerName) => Parse(serviceProducerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceProducerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceProducerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceProducerName"/> if successful.</returns>
        public static ServiceProducerName Parse(string serviceProducerName, bool allowUnparsed) =>
            TryParse(serviceProducerName, allowUnparsed, out ServiceProducerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceProducerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceProducerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceProducerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceProducerName, out ServiceProducerName result) =>
            TryParse(serviceProducerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceProducerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/serviceProducers/{service_producer}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceProducerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceProducerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceProducerName, bool allowUnparsed, out ServiceProducerName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceProducerName, nameof(serviceProducerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceProducer.TryParseName(serviceProducerName, out resourceName))
            {
                result = FromProjectLocationServiceProducer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationServiceProducer.TryParseName(serviceProducerName, out resourceName))
            {
                result = FromFolderLocationServiceProducer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationServiceProducer.TryParseName(serviceProducerName, out resourceName))
            {
                result = FromOrganizationLocationServiceProducer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceProducerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceProducerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string serviceProducerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ServiceProducerId = serviceProducerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceProducerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/serviceProducers/{service_producer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProducerId">The <c>ServiceProducer</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceProducerName(string projectId, string locationId, string serviceProducerId) : this(ResourceNameType.ProjectLocationServiceProducer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProducerId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProducerId, nameof(serviceProducerId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ServiceProducer</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ServiceProducerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceProducer: return s_projectLocationServiceProducer.Expand(ProjectId, LocationId, ServiceProducerId);
                case ResourceNameType.FolderLocationServiceProducer: return s_folderLocationServiceProducer.Expand(FolderId, LocationId, ServiceProducerId);
                case ResourceNameType.OrganizationLocationServiceProducer: return s_organizationLocationServiceProducer.Expand(OrganizationId, LocationId, ServiceProducerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceProducerName);

        /// <inheritdoc/>
        public bool Equals(ServiceProducerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceProducerName a, ServiceProducerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceProducerName a, ServiceProducerName b) => !(a == b);
    }

    public partial class ServiceAgent
    {
        /// <summary>
        /// <see cref="gcwv::ServiceAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcwv::ServiceAgentName ServiceAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcwv::ServiceAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Container"/> resource name property.
        /// </summary>
        public gax::IResourceName ContainerAsResourceName
        {
            get => string.IsNullOrEmpty(Container) ? null : gax::UnparsedResourceName.Parse(Container);
            set => Container = value?.ToString() ?? "";
        }
    }

    public partial class GenerateServiceAgentsRequest
    {
        /// <summary>
        /// <see cref="ServiceProducerName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ServiceProducerName ParentAsServiceProducerName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ServiceProducerName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
