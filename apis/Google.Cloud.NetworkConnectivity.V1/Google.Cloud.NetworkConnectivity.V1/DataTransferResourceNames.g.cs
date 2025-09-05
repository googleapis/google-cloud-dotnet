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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkConnectivity.V1;
using sys = System;

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Resource name for the <c>MulticloudDataTransferConfig</c> resource.</summary>
    public sealed partial class MulticloudDataTransferConfigName : gax::IResourceName, sys::IEquatable<MulticloudDataTransferConfigName>
    {
        /// <summary>The possible contents of <see cref="MulticloudDataTransferConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
            /// .
            /// </summary>
            ProjectLocationMulticloudDataTransferConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationMulticloudDataTransferConfig = new gax::PathTemplate("projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}");

        /// <summary>
        /// Creates a <see cref="MulticloudDataTransferConfigName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MulticloudDataTransferConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MulticloudDataTransferConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MulticloudDataTransferConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MulticloudDataTransferConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MulticloudDataTransferConfigName"/> constructed from the provided ids.
        /// </returns>
        public static MulticloudDataTransferConfigName FromProjectLocationMulticloudDataTransferConfig(string projectId, string locationId, string multicloudDataTransferConfigId) =>
            new MulticloudDataTransferConfigName(ResourceNameType.ProjectLocationMulticloudDataTransferConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MulticloudDataTransferConfigName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MulticloudDataTransferConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string multicloudDataTransferConfigId) =>
            FormatProjectLocationMulticloudDataTransferConfig(projectId, locationId, multicloudDataTransferConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MulticloudDataTransferConfigName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MulticloudDataTransferConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMulticloudDataTransferConfig(string projectId, string locationId, string multicloudDataTransferConfigId) =>
            s_projectLocationMulticloudDataTransferConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MulticloudDataTransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="multicloudDataTransferConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MulticloudDataTransferConfigName"/> if successful.</returns>
        public static MulticloudDataTransferConfigName Parse(string multicloudDataTransferConfigName) =>
            Parse(multicloudDataTransferConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MulticloudDataTransferConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="multicloudDataTransferConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MulticloudDataTransferConfigName"/> if successful.</returns>
        public static MulticloudDataTransferConfigName Parse(string multicloudDataTransferConfigName, bool allowUnparsed) =>
            TryParse(multicloudDataTransferConfigName, allowUnparsed, out MulticloudDataTransferConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MulticloudDataTransferConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="multicloudDataTransferConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MulticloudDataTransferConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string multicloudDataTransferConfigName, out MulticloudDataTransferConfigName result) =>
            TryParse(multicloudDataTransferConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MulticloudDataTransferConfigName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="multicloudDataTransferConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MulticloudDataTransferConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string multicloudDataTransferConfigName, bool allowUnparsed, out MulticloudDataTransferConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfigName, nameof(multicloudDataTransferConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMulticloudDataTransferConfig.TryParseName(multicloudDataTransferConfigName, out resourceName))
            {
                result = FromProjectLocationMulticloudDataTransferConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(multicloudDataTransferConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MulticloudDataTransferConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string multicloudDataTransferConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MulticloudDataTransferConfigId = multicloudDataTransferConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MulticloudDataTransferConfigName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MulticloudDataTransferConfigName(string projectId, string locationId, string multicloudDataTransferConfigId) : this(ResourceNameType.ProjectLocationMulticloudDataTransferConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)))
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
        /// The <c>MulticloudDataTransferConfig</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string MulticloudDataTransferConfigId { get; }

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
                case ResourceNameType.ProjectLocationMulticloudDataTransferConfig: return s_projectLocationMulticloudDataTransferConfig.Expand(ProjectId, LocationId, MulticloudDataTransferConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MulticloudDataTransferConfigName);

        /// <inheritdoc/>
        public bool Equals(MulticloudDataTransferConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MulticloudDataTransferConfigName a, MulticloudDataTransferConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MulticloudDataTransferConfigName a, MulticloudDataTransferConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Destination</c> resource.</summary>
    public sealed partial class DestinationName : gax::IResourceName, sys::IEquatable<DestinationName>
    {
        /// <summary>The possible contents of <see cref="DestinationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
            /// .
            /// </summary>
            ProjectLocationMulticloudDataTransferConfigDestination = 1,
        }

        private static gax::PathTemplate s_projectLocationMulticloudDataTransferConfigDestination = new gax::PathTemplate("projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}");

        /// <summary>Creates a <see cref="DestinationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DestinationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DestinationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DestinationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DestinationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="destinationId">The <c>Destination</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DestinationName"/> constructed from the provided ids.</returns>
        public static DestinationName FromProjectLocationMulticloudDataTransferConfigDestination(string projectId, string locationId, string multicloudDataTransferConfigId, string destinationId) =>
            new DestinationName(ResourceNameType.ProjectLocationMulticloudDataTransferConfigDestination, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)), destinationId: gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DestinationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="destinationId">The <c>Destination</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DestinationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string multicloudDataTransferConfigId, string destinationId) =>
            FormatProjectLocationMulticloudDataTransferConfigDestination(projectId, locationId, multicloudDataTransferConfigId, destinationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DestinationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="destinationId">The <c>Destination</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DestinationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMulticloudDataTransferConfigDestination(string projectId, string locationId, string multicloudDataTransferConfigId, string destinationId) =>
            s_projectLocationMulticloudDataTransferConfigDestination.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)));

        /// <summary>Parses the given resource name string into a new <see cref="DestinationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="destinationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DestinationName"/> if successful.</returns>
        public static DestinationName Parse(string destinationName) => Parse(destinationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DestinationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="destinationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DestinationName"/> if successful.</returns>
        public static DestinationName Parse(string destinationName, bool allowUnparsed) =>
            TryParse(destinationName, allowUnparsed, out DestinationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DestinationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="destinationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DestinationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string destinationName, out DestinationName result) =>
            TryParse(destinationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DestinationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="destinationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DestinationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string destinationName, bool allowUnparsed, out DestinationName result)
        {
            gax::GaxPreconditions.CheckNotNull(destinationName, nameof(destinationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMulticloudDataTransferConfigDestination.TryParseName(destinationName, out resourceName))
            {
                result = FromProjectLocationMulticloudDataTransferConfigDestination(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(destinationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DestinationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string destinationId = null, string locationId = null, string multicloudDataTransferConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DestinationId = destinationId;
            LocationId = locationId;
            MulticloudDataTransferConfigId = multicloudDataTransferConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DestinationName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferConfigs/{multicloud_data_transfer_config}/destinations/{destination}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferConfigId">
        /// The <c>MulticloudDataTransferConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="destinationId">The <c>Destination</c> ID. Must not be <c>null</c> or empty.</param>
        public DestinationName(string projectId, string locationId, string multicloudDataTransferConfigId, string destinationId) : this(ResourceNameType.ProjectLocationMulticloudDataTransferConfigDestination, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)), destinationId: gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)))
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
        /// The <c>Destination</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DestinationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MulticloudDataTransferConfig</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string MulticloudDataTransferConfigId { get; }

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
                case ResourceNameType.ProjectLocationMulticloudDataTransferConfigDestination: return s_projectLocationMulticloudDataTransferConfigDestination.Expand(ProjectId, LocationId, MulticloudDataTransferConfigId, DestinationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DestinationName);

        /// <inheritdoc/>
        public bool Equals(DestinationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DestinationName a, DestinationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DestinationName a, DestinationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MulticloudDataTransferSupportedService</c> resource.</summary>
    public sealed partial class MulticloudDataTransferSupportedServiceName : gax::IResourceName, sys::IEquatable<MulticloudDataTransferSupportedServiceName>
    {
        /// <summary>The possible contents of <see cref="MulticloudDataTransferSupportedServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
            /// .
            /// </summary>
            ProjectLocationMulticloudDataTransferSupportedService = 1,
        }

        private static gax::PathTemplate s_projectLocationMulticloudDataTransferSupportedService = new gax::PathTemplate("projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}");

        /// <summary>
        /// Creates a <see cref="MulticloudDataTransferSupportedServiceName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MulticloudDataTransferSupportedServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MulticloudDataTransferSupportedServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MulticloudDataTransferSupportedServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MulticloudDataTransferSupportedServiceName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferSupportedServiceId">
        /// The <c>MulticloudDataTransferSupportedService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="MulticloudDataTransferSupportedServiceName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static MulticloudDataTransferSupportedServiceName FromProjectLocationMulticloudDataTransferSupportedService(string projectId, string locationId, string multicloudDataTransferSupportedServiceId) =>
            new MulticloudDataTransferSupportedServiceName(ResourceNameType.ProjectLocationMulticloudDataTransferSupportedService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferSupportedServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferSupportedServiceId, nameof(multicloudDataTransferSupportedServiceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="MulticloudDataTransferSupportedServiceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferSupportedServiceId">
        /// The <c>MulticloudDataTransferSupportedService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MulticloudDataTransferSupportedServiceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string multicloudDataTransferSupportedServiceId) =>
            FormatProjectLocationMulticloudDataTransferSupportedService(projectId, locationId, multicloudDataTransferSupportedServiceId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="MulticloudDataTransferSupportedServiceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferSupportedServiceId">
        /// The <c>MulticloudDataTransferSupportedService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="MulticloudDataTransferSupportedServiceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMulticloudDataTransferSupportedService(string projectId, string locationId, string multicloudDataTransferSupportedServiceId) =>
            s_projectLocationMulticloudDataTransferSupportedService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferSupportedServiceId, nameof(multicloudDataTransferSupportedServiceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MulticloudDataTransferSupportedServiceName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="multicloudDataTransferSupportedServiceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MulticloudDataTransferSupportedServiceName"/> if successful.</returns>
        public static MulticloudDataTransferSupportedServiceName Parse(string multicloudDataTransferSupportedServiceName) =>
            Parse(multicloudDataTransferSupportedServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MulticloudDataTransferSupportedServiceName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="multicloudDataTransferSupportedServiceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MulticloudDataTransferSupportedServiceName"/> if successful.</returns>
        public static MulticloudDataTransferSupportedServiceName Parse(string multicloudDataTransferSupportedServiceName, bool allowUnparsed) =>
            TryParse(multicloudDataTransferSupportedServiceName, allowUnparsed, out MulticloudDataTransferSupportedServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="MulticloudDataTransferSupportedServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="multicloudDataTransferSupportedServiceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MulticloudDataTransferSupportedServiceName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string multicloudDataTransferSupportedServiceName, out MulticloudDataTransferSupportedServiceName result) =>
            TryParse(multicloudDataTransferSupportedServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="MulticloudDataTransferSupportedServiceName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="multicloudDataTransferSupportedServiceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MulticloudDataTransferSupportedServiceName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string multicloudDataTransferSupportedServiceName, bool allowUnparsed, out MulticloudDataTransferSupportedServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(multicloudDataTransferSupportedServiceName, nameof(multicloudDataTransferSupportedServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMulticloudDataTransferSupportedService.TryParseName(multicloudDataTransferSupportedServiceName, out resourceName))
            {
                result = FromProjectLocationMulticloudDataTransferSupportedService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(multicloudDataTransferSupportedServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MulticloudDataTransferSupportedServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string multicloudDataTransferSupportedServiceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MulticloudDataTransferSupportedServiceId = multicloudDataTransferSupportedServiceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MulticloudDataTransferSupportedServiceName"/> class from the
        /// component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/multicloudDataTransferSupportedServices/{multicloud_data_transfer_supported_service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="multicloudDataTransferSupportedServiceId">
        /// The <c>MulticloudDataTransferSupportedService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public MulticloudDataTransferSupportedServiceName(string projectId, string locationId, string multicloudDataTransferSupportedServiceId) : this(ResourceNameType.ProjectLocationMulticloudDataTransferSupportedService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), multicloudDataTransferSupportedServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferSupportedServiceId, nameof(multicloudDataTransferSupportedServiceId)))
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
        /// The <c>MulticloudDataTransferSupportedService</c> ID. Will not be <c>null</c>, unless this instance contains
        /// an unparsed resource name.
        /// </summary>
        public string MulticloudDataTransferSupportedServiceId { get; }

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
                case ResourceNameType.ProjectLocationMulticloudDataTransferSupportedService: return s_projectLocationMulticloudDataTransferSupportedService.Expand(ProjectId, LocationId, MulticloudDataTransferSupportedServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MulticloudDataTransferSupportedServiceName);

        /// <inheritdoc/>
        public bool Equals(MulticloudDataTransferSupportedServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MulticloudDataTransferSupportedServiceName a, MulticloudDataTransferSupportedServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MulticloudDataTransferSupportedServiceName a, MulticloudDataTransferSupportedServiceName b) => !(a == b);
    }

    public partial class MulticloudDataTransferConfig
    {
        /// <summary>
        /// <see cref="gcnv::MulticloudDataTransferConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MulticloudDataTransferConfigName MulticloudDataTransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MulticloudDataTransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMulticloudDataTransferConfigsRequest
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

    public partial class GetMulticloudDataTransferConfigRequest
    {
        /// <summary>
        /// <see cref="gcnv::MulticloudDataTransferConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MulticloudDataTransferConfigName MulticloudDataTransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MulticloudDataTransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMulticloudDataTransferConfigRequest
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

    public partial class DeleteMulticloudDataTransferConfigRequest
    {
        /// <summary>
        /// <see cref="gcnv::MulticloudDataTransferConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::MulticloudDataTransferConfigName MulticloudDataTransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MulticloudDataTransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Destination
    {
        /// <summary>
        /// <see cref="gcnv::DestinationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::DestinationName DestinationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::DestinationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDestinationsRequest
    {
        /// <summary>
        /// <see cref="MulticloudDataTransferConfigName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        public MulticloudDataTransferConfigName ParentAsMulticloudDataTransferConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MulticloudDataTransferConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDestinationRequest
    {
        /// <summary>
        /// <see cref="gcnv::DestinationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::DestinationName DestinationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::DestinationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDestinationRequest
    {
        /// <summary>
        /// <see cref="MulticloudDataTransferConfigName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        public MulticloudDataTransferConfigName ParentAsMulticloudDataTransferConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MulticloudDataTransferConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDestinationRequest
    {
        /// <summary>
        /// <see cref="gcnv::DestinationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::DestinationName DestinationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::DestinationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MulticloudDataTransferSupportedService
    {
        /// <summary>
        /// <see cref="gcnv::MulticloudDataTransferSupportedServiceName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcnv::MulticloudDataTransferSupportedServiceName MulticloudDataTransferSupportedServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MulticloudDataTransferSupportedServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMulticloudDataTransferSupportedServiceRequest
    {
        /// <summary>
        /// <see cref="gcnv::MulticloudDataTransferSupportedServiceName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcnv::MulticloudDataTransferSupportedServiceName MulticloudDataTransferSupportedServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::MulticloudDataTransferSupportedServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMulticloudDataTransferSupportedServicesRequest
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
}
