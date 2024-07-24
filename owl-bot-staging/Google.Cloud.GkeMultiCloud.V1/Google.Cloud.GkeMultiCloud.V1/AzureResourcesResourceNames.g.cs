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
using gcgv = Google.Cloud.GkeMultiCloud.V1;
using sys = System;

namespace Google.Cloud.GkeMultiCloud.V1
{
    /// <summary>Resource name for the <c>AzureCluster</c> resource.</summary>
    public sealed partial class AzureClusterName : gax::IResourceName, sys::IEquatable<AzureClusterName>
    {
        /// <summary>The possible contents of <see cref="AzureClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>
            /// .
            /// </summary>
            ProjectLocationAzureCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationAzureCluster = new gax::PathTemplate("projects/{project}/locations/{location}/azureClusters/{azure_cluster}");

        /// <summary>Creates a <see cref="AzureClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AzureClusterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AzureClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AzureClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AzureClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AzureClusterName"/> constructed from the provided ids.</returns>
        public static AzureClusterName FromProjectLocationAzureCluster(string projectId, string locationId, string azureClusterId) =>
            new AzureClusterName(ResourceNameType.ProjectLocationAzureCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string azureClusterId) =>
            FormatProjectLocationAzureCluster(projectId, locationId, azureClusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationAzureCluster(string projectId, string locationId, string azureClusterId) =>
            s_projectLocationAzureCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="AzureClusterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AzureClusterName"/> if successful.</returns>
        public static AzureClusterName Parse(string azureClusterName) => Parse(azureClusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AzureClusterName"/> if successful.</returns>
        public static AzureClusterName Parse(string azureClusterName, bool allowUnparsed) =>
            TryParse(azureClusterName, allowUnparsed, out AzureClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureClusterName, out AzureClusterName result) =>
            TryParse(azureClusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureClusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureClusterName, bool allowUnparsed, out AzureClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(azureClusterName, nameof(azureClusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAzureCluster.TryParseName(azureClusterName, out resourceName))
            {
                result = FromProjectLocationAzureCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(azureClusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AzureClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string azureClusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AzureClusterId = azureClusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AzureClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        public AzureClusterName(string projectId, string locationId, string azureClusterId) : this(ResourceNameType.ProjectLocationAzureCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)))
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
        /// The <c>AzureCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AzureClusterId { get; }

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
                case ResourceNameType.ProjectLocationAzureCluster: return s_projectLocationAzureCluster.Expand(ProjectId, LocationId, AzureClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AzureClusterName);

        /// <inheritdoc/>
        public bool Equals(AzureClusterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AzureClusterName a, AzureClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AzureClusterName a, AzureClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AzureClient</c> resource.</summary>
    public sealed partial class AzureClientName : gax::IResourceName, sys::IEquatable<AzureClientName>
    {
        /// <summary>The possible contents of <see cref="AzureClientName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
            /// </summary>
            ProjectLocationAzureClient = 1,
        }

        private static gax::PathTemplate s_projectLocationAzureClient = new gax::PathTemplate("projects/{project}/locations/{location}/azureClients/{azure_client}");

        /// <summary>Creates a <see cref="AzureClientName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AzureClientName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AzureClientName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AzureClientName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AzureClientName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClientId">The <c>AzureClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AzureClientName"/> constructed from the provided ids.</returns>
        public static AzureClientName FromProjectLocationAzureClient(string projectId, string locationId, string azureClientId) =>
            new AzureClientName(ResourceNameType.ProjectLocationAzureClient, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClientId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureClientName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClientId">The <c>AzureClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureClientName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string azureClientId) =>
            FormatProjectLocationAzureClient(projectId, locationId, azureClientId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureClientName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClientId">The <c>AzureClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureClientName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>.
        /// </returns>
        public static string FormatProjectLocationAzureClient(string projectId, string locationId, string azureClientId) =>
            s_projectLocationAzureClient.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)));

        /// <summary>Parses the given resource name string into a new <see cref="AzureClientName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClients/{azure_client}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AzureClientName"/> if successful.</returns>
        public static AzureClientName Parse(string azureClientName) => Parse(azureClientName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureClientName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClients/{azure_client}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AzureClientName"/> if successful.</returns>
        public static AzureClientName Parse(string azureClientName, bool allowUnparsed) =>
            TryParse(azureClientName, allowUnparsed, out AzureClientName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureClientName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClients/{azure_client}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureClientName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureClientName, out AzureClientName result) =>
            TryParse(azureClientName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureClientName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/azureClients/{azure_client}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureClientName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureClientName, bool allowUnparsed, out AzureClientName result)
        {
            gax::GaxPreconditions.CheckNotNull(azureClientName, nameof(azureClientName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAzureClient.TryParseName(azureClientName, out resourceName))
            {
                result = FromProjectLocationAzureClient(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(azureClientName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AzureClientName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string azureClientId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AzureClientId = azureClientId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AzureClientName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/azureClients/{azure_client}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClientId">The <c>AzureClient</c> ID. Must not be <c>null</c> or empty.</param>
        public AzureClientName(string projectId, string locationId, string azureClientId) : this(ResourceNameType.ProjectLocationAzureClient, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClientId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClientId, nameof(azureClientId)))
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
        /// The <c>AzureClient</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AzureClientId { get; }

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
                case ResourceNameType.ProjectLocationAzureClient: return s_projectLocationAzureClient.Expand(ProjectId, LocationId, AzureClientId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AzureClientName);

        /// <inheritdoc/>
        public bool Equals(AzureClientName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AzureClientName a, AzureClientName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AzureClientName a, AzureClientName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AzureNodePool</c> resource.</summary>
    public sealed partial class AzureNodePoolName : gax::IResourceName, sys::IEquatable<AzureNodePoolName>
    {
        /// <summary>The possible contents of <see cref="AzureNodePoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
            /// .
            /// </summary>
            ProjectLocationAzureClusterAzureNodePool = 1,
        }

        private static gax::PathTemplate s_projectLocationAzureClusterAzureNodePool = new gax::PathTemplate("projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}");

        /// <summary>Creates a <see cref="AzureNodePoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AzureNodePoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AzureNodePoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AzureNodePoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AzureNodePoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureNodePoolId">The <c>AzureNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AzureNodePoolName"/> constructed from the provided ids.</returns>
        public static AzureNodePoolName FromProjectLocationAzureClusterAzureNodePool(string projectId, string locationId, string azureClusterId, string azureNodePoolId) =>
            new AzureNodePoolName(ResourceNameType.ProjectLocationAzureClusterAzureNodePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)), azureNodePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureNodePoolId">The <c>AzureNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string azureClusterId, string azureNodePoolId) =>
            FormatProjectLocationAzureClusterAzureNodePool(projectId, locationId, azureClusterId, azureNodePoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureNodePoolId">The <c>AzureNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureNodePoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAzureClusterAzureNodePool(string projectId, string locationId, string azureClusterId, string azureNodePoolId) =>
            s_projectLocationAzureClusterAzureNodePool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureNodePoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AzureNodePoolName"/> if successful.</returns>
        public static AzureNodePoolName Parse(string azureNodePoolName) => Parse(azureNodePoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureNodePoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AzureNodePoolName"/> if successful.</returns>
        public static AzureNodePoolName Parse(string azureNodePoolName, bool allowUnparsed) =>
            TryParse(azureNodePoolName, allowUnparsed, out AzureNodePoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureNodePoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="azureNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureNodePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureNodePoolName, out AzureNodePoolName result) =>
            TryParse(azureNodePoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureNodePoolName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureNodePoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureNodePoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureNodePoolName, bool allowUnparsed, out AzureNodePoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(azureNodePoolName, nameof(azureNodePoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAzureClusterAzureNodePool.TryParseName(azureNodePoolName, out resourceName))
            {
                result = FromProjectLocationAzureClusterAzureNodePool(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(azureNodePoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AzureNodePoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string azureClusterId = null, string azureNodePoolId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AzureClusterId = azureClusterId;
            AzureNodePoolId = azureNodePoolId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AzureNodePoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/azureClusters/{azure_cluster}/azureNodePools/{azure_node_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureClusterId">The <c>AzureCluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="azureNodePoolId">The <c>AzureNodePool</c> ID. Must not be <c>null</c> or empty.</param>
        public AzureNodePoolName(string projectId, string locationId, string azureClusterId, string azureNodePoolId) : this(ResourceNameType.ProjectLocationAzureClusterAzureNodePool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), azureClusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureClusterId, nameof(azureClusterId)), azureNodePoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(azureNodePoolId, nameof(azureNodePoolId)))
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
        /// The <c>AzureCluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AzureClusterId { get; }

        /// <summary>
        /// The <c>AzureNodePool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AzureNodePoolId { get; }

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
                case ResourceNameType.ProjectLocationAzureClusterAzureNodePool: return s_projectLocationAzureClusterAzureNodePool.Expand(ProjectId, LocationId, AzureClusterId, AzureNodePoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AzureNodePoolName);

        /// <inheritdoc/>
        public bool Equals(AzureNodePoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AzureNodePoolName a, AzureNodePoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AzureNodePoolName a, AzureNodePoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AzureServerConfig</c> resource.</summary>
    public sealed partial class AzureServerConfigName : gax::IResourceName, sys::IEquatable<AzureServerConfigName>
    {
        /// <summary>The possible contents of <see cref="AzureServerConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/azureServerConfig</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/azureServerConfig");

        /// <summary>Creates a <see cref="AzureServerConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AzureServerConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AzureServerConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AzureServerConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AzureServerConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AzureServerConfigName"/> constructed from the provided ids.</returns>
        public static AzureServerConfigName FromProjectLocation(string projectId, string locationId) =>
            new AzureServerConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AzureServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AzureServerConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/azureServerConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="azureServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AzureServerConfigName"/> if successful.</returns>
        public static AzureServerConfigName Parse(string azureServerConfigName) => Parse(azureServerConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AzureServerConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/azureServerConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AzureServerConfigName"/> if successful.</returns>
        public static AzureServerConfigName Parse(string azureServerConfigName, bool allowUnparsed) =>
            TryParse(azureServerConfigName, allowUnparsed, out AzureServerConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureServerConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/azureServerConfig</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="azureServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureServerConfigName, out AzureServerConfigName result) =>
            TryParse(azureServerConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AzureServerConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/azureServerConfig</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="azureServerConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AzureServerConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string azureServerConfigName, bool allowUnparsed, out AzureServerConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(azureServerConfigName, nameof(azureServerConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(azureServerConfigName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(azureServerConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AzureServerConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AzureServerConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/azureServerConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public AzureServerConfigName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AzureServerConfigName);

        /// <inheritdoc/>
        public bool Equals(AzureServerConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AzureServerConfigName a, AzureServerConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AzureServerConfigName a, AzureServerConfigName b) => !(a == b);
    }

    public partial class AzureCluster
    {
        /// <summary>
        /// <see cref="gcgv::AzureClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClusterName AzureClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AzureClient
    {
        /// <summary>
        /// <see cref="gcgv::AzureClientName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClientName AzureClientName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClientName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AzureNodePool
    {
        /// <summary>
        /// <see cref="gcgv::AzureNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureNodePoolName AzureNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AzureServerConfig
    {
        /// <summary>
        /// <see cref="gcgv::AzureServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureServerConfigName AzureServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
