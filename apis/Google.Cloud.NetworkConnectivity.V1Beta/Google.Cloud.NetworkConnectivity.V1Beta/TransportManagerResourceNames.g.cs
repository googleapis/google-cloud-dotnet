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
using gcnv = Google.Cloud.NetworkConnectivity.V1Beta;
using sys = System;

namespace Google.Cloud.NetworkConnectivity.V1Beta
{
    /// <summary>Resource name for the <c>RemoteTransportProfile</c> resource.</summary>
    public sealed partial class RemoteTransportProfileName : gax::IResourceName, sys::IEquatable<RemoteTransportProfileName>
    {
        /// <summary>The possible contents of <see cref="RemoteTransportProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
            /// </summary>
            ProjectLocationRemoteTransportProfile = 1,
        }

        private static gax::PathTemplate s_projectLocationRemoteTransportProfile = new gax::PathTemplate("projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}");

        /// <summary>Creates a <see cref="RemoteTransportProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RemoteTransportProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RemoteTransportProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RemoteTransportProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RemoteTransportProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="remoteTransportProfileId">
        /// The <c>RemoteTransportProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="RemoteTransportProfileName"/> constructed from the provided ids.
        /// </returns>
        public static RemoteTransportProfileName FromProjectLocationRemoteTransportProfile(string projectId, string locationId, string remoteTransportProfileId) =>
            new RemoteTransportProfileName(ResourceNameType.ProjectLocationRemoteTransportProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), remoteTransportProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(remoteTransportProfileId, nameof(remoteTransportProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RemoteTransportProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="remoteTransportProfileId">
        /// The <c>RemoteTransportProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RemoteTransportProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string remoteTransportProfileId) =>
            FormatProjectLocationRemoteTransportProfile(projectId, locationId, remoteTransportProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RemoteTransportProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="remoteTransportProfileId">
        /// The <c>RemoteTransportProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RemoteTransportProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationRemoteTransportProfile(string projectId, string locationId, string remoteTransportProfileId) =>
            s_projectLocationRemoteTransportProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(remoteTransportProfileId, nameof(remoteTransportProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RemoteTransportProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="remoteTransportProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RemoteTransportProfileName"/> if successful.</returns>
        public static RemoteTransportProfileName Parse(string remoteTransportProfileName) =>
            Parse(remoteTransportProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RemoteTransportProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="remoteTransportProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RemoteTransportProfileName"/> if successful.</returns>
        public static RemoteTransportProfileName Parse(string remoteTransportProfileName, bool allowUnparsed) =>
            TryParse(remoteTransportProfileName, allowUnparsed, out RemoteTransportProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RemoteTransportProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="remoteTransportProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RemoteTransportProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string remoteTransportProfileName, out RemoteTransportProfileName result) =>
            TryParse(remoteTransportProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RemoteTransportProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="remoteTransportProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RemoteTransportProfileName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string remoteTransportProfileName, bool allowUnparsed, out RemoteTransportProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(remoteTransportProfileName, nameof(remoteTransportProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRemoteTransportProfile.TryParseName(remoteTransportProfileName, out resourceName))
            {
                result = FromProjectLocationRemoteTransportProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(remoteTransportProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RemoteTransportProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string remoteTransportProfileId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RemoteTransportProfileId = remoteTransportProfileId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RemoteTransportProfileName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/remoteTransportProfiles/{remote_transport_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="remoteTransportProfileId">
        /// The <c>RemoteTransportProfile</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public RemoteTransportProfileName(string projectId, string locationId, string remoteTransportProfileId) : this(ResourceNameType.ProjectLocationRemoteTransportProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), remoteTransportProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(remoteTransportProfileId, nameof(remoteTransportProfileId)))
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
        /// The <c>RemoteTransportProfile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RemoteTransportProfileId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRemoteTransportProfile: return s_projectLocationRemoteTransportProfile.Expand(ProjectId, LocationId, RemoteTransportProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RemoteTransportProfileName);

        /// <inheritdoc/>
        public bool Equals(RemoteTransportProfileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RemoteTransportProfileName a, RemoteTransportProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RemoteTransportProfileName a, RemoteTransportProfileName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Transport</c> resource.</summary>
    public sealed partial class TransportName : gax::IResourceName, sys::IEquatable<TransportName>
    {
        /// <summary>The possible contents of <see cref="TransportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/transports/{transport}</c>.
            /// </summary>
            ProjectLocationTransport = 1,
        }

        private static gax::PathTemplate s_projectLocationTransport = new gax::PathTemplate("projects/{project}/locations/{location}/transports/{transport}");

        /// <summary>Creates a <see cref="TransportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TransportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TransportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TransportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TransportName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transportId">The <c>Transport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TransportName"/> constructed from the provided ids.</returns>
        public static TransportName FromProjectLocationTransport(string projectId, string locationId, string transportId) =>
            new TransportName(ResourceNameType.ProjectLocationTransport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), transportId: gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transportId">The <c>Transport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TransportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string transportId) =>
            FormatProjectLocationTransport(projectId, locationId, transportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transportId">The <c>Transport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TransportName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>.
        /// </returns>
        public static string FormatProjectLocationTransport(string projectId, string locationId, string transportId) =>
            s_projectLocationTransport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)));

        /// <summary>Parses the given resource name string into a new <see cref="TransportName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transports/{transport}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransportName"/> if successful.</returns>
        public static TransportName Parse(string transportName) => Parse(transportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TransportName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transports/{transport}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TransportName"/> if successful.</returns>
        public static TransportName Parse(string transportName, bool allowUnparsed) =>
            TryParse(transportName, allowUnparsed, out TransportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transports/{transport}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transportName, out TransportName result) => TryParse(transportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transports/{transport}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transportName, bool allowUnparsed, out TransportName result)
        {
            gax::GaxPreconditions.CheckNotNull(transportName, nameof(transportName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTransport.TryParseName(transportName, out resourceName))
            {
                result = FromProjectLocationTransport(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TransportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string transportId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TransportId = transportId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TransportName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/transports/{transport}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transportId">The <c>Transport</c> ID. Must not be <c>null</c> or empty.</param>
        public TransportName(string projectId, string locationId, string transportId) : this(ResourceNameType.ProjectLocationTransport, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), transportId: gax::GaxPreconditions.CheckNotNullOrEmpty(transportId, nameof(transportId)))
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
        /// The <c>Transport</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TransportId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTransport: return s_projectLocationTransport.Expand(ProjectId, LocationId, TransportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TransportName);

        /// <inheritdoc/>
        public bool Equals(TransportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TransportName a, TransportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TransportName a, TransportName b) => !(a == b);
    }

    public partial class RemoteTransportProfile
    {
        /// <summary>
        /// <see cref="gcnv::RemoteTransportProfileName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::RemoteTransportProfileName RemoteTransportProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::RemoteTransportProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRemoteTransportProfilesRequest
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

    public partial class GetRemoteTransportProfileRequest
    {
        /// <summary>
        /// <see cref="gcnv::RemoteTransportProfileName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::RemoteTransportProfileName RemoteTransportProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::RemoteTransportProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Transport
    {
        /// <summary>
        /// <see cref="gcnv::TransportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TransportName TransportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TransportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RemoteTransportProfileName"/>-typed view over the <see cref="RemoteProfile"/> resource name
        /// property.
        /// </summary>
        public RemoteTransportProfileName RemoteProfileAsRemoteTransportProfileName
        {
            get => string.IsNullOrEmpty(RemoteProfile) ? null : RemoteTransportProfileName.Parse(RemoteProfile, allowUnparsed: true);
            set => RemoteProfile = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class ListTransportsRequest
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

    public partial class GetTransportRequest
    {
        /// <summary>
        /// <see cref="gcnv::TransportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TransportName TransportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TransportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetStatusRequest
    {
        /// <summary>
        /// <see cref="gcnv::TransportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TransportName TransportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TransportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTransportRequest
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

    public partial class DeleteTransportRequest
    {
        /// <summary>
        /// <see cref="gcnv::TransportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::TransportName TransportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::TransportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
