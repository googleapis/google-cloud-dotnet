// Copyright 2022 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gcbcv = Google.Cloud.BeyondCorp.ClientConnectorServices.V1;
using sys = System;

namespace Google.Cloud.BeyondCorp.ClientConnectorServices.V1
{
    /// <summary>Resource name for the <c>ClientConnectorService</c> resource.</summary>
    public sealed partial class ClientConnectorServiceName : gax::IResourceName, sys::IEquatable<ClientConnectorServiceName>
    {
        /// <summary>The possible contents of <see cref="ClientConnectorServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
            /// </summary>
            ProjectLocationClientConnectorService = 1,
        }

        private static gax::PathTemplate s_projectLocationClientConnectorService = new gax::PathTemplate("projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}");

        /// <summary>Creates a <see cref="ClientConnectorServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClientConnectorServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClientConnectorServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClientConnectorServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClientConnectorServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientConnectorServiceId">
        /// The <c>ClientConnectorService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ClientConnectorServiceName"/> constructed from the provided ids.
        /// </returns>
        public static ClientConnectorServiceName FromProjectLocationClientConnectorService(string projectId, string locationId, string clientConnectorServiceId) =>
            new ClientConnectorServiceName(ResourceNameType.ProjectLocationClientConnectorService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clientConnectorServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientConnectorServiceId, nameof(clientConnectorServiceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClientConnectorServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientConnectorServiceId">
        /// The <c>ClientConnectorService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ClientConnectorServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clientConnectorServiceId) =>
            FormatProjectLocationClientConnectorService(projectId, locationId, clientConnectorServiceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClientConnectorServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientConnectorServiceId">
        /// The <c>ClientConnectorService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ClientConnectorServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>.
        /// </returns>
        public static string FormatProjectLocationClientConnectorService(string projectId, string locationId, string clientConnectorServiceId) =>
            s_projectLocationClientConnectorService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clientConnectorServiceId, nameof(clientConnectorServiceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClientConnectorServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clientConnectorServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClientConnectorServiceName"/> if successful.</returns>
        public static ClientConnectorServiceName Parse(string clientConnectorServiceName) =>
            Parse(clientConnectorServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClientConnectorServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clientConnectorServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClientConnectorServiceName"/> if successful.</returns>
        public static ClientConnectorServiceName Parse(string clientConnectorServiceName, bool allowUnparsed) =>
            TryParse(clientConnectorServiceName, allowUnparsed, out ClientConnectorServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClientConnectorServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clientConnectorServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClientConnectorServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clientConnectorServiceName, out ClientConnectorServiceName result) =>
            TryParse(clientConnectorServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClientConnectorServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clientConnectorServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClientConnectorServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clientConnectorServiceName, bool allowUnparsed, out ClientConnectorServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(clientConnectorServiceName, nameof(clientConnectorServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClientConnectorService.TryParseName(clientConnectorServiceName, out resourceName))
            {
                result = FromProjectLocationClientConnectorService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clientConnectorServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClientConnectorServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientConnectorServiceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientConnectorServiceId = clientConnectorServiceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClientConnectorServiceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/clientConnectorServices/{client_connector_service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientConnectorServiceId">
        /// The <c>ClientConnectorService</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ClientConnectorServiceName(string projectId, string locationId, string clientConnectorServiceId) : this(ResourceNameType.ProjectLocationClientConnectorService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clientConnectorServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientConnectorServiceId, nameof(clientConnectorServiceId)))
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
        /// The <c>ClientConnectorService</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ClientConnectorServiceId { get; }

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
                case ResourceNameType.ProjectLocationClientConnectorService: return s_projectLocationClientConnectorService.Expand(ProjectId, LocationId, ClientConnectorServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClientConnectorServiceName);

        /// <inheritdoc/>
        public bool Equals(ClientConnectorServiceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ClientConnectorServiceName a, ClientConnectorServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ClientConnectorServiceName a, ClientConnectorServiceName b) => !(a == b);
    }

    public partial class ClientConnectorService
    {
        /// <summary>
        /// <see cref="gcbcv::ClientConnectorServiceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbcv::ClientConnectorServiceName ClientConnectorServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::ClientConnectorServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListClientConnectorServicesRequest
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

    public partial class GetClientConnectorServiceRequest
    {
        /// <summary>
        /// <see cref="gcbcv::ClientConnectorServiceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbcv::ClientConnectorServiceName ClientConnectorServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::ClientConnectorServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClientConnectorServiceRequest
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

    public partial class DeleteClientConnectorServiceRequest
    {
        /// <summary>
        /// <see cref="gcbcv::ClientConnectorServiceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbcv::ClientConnectorServiceName ClientConnectorServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::ClientConnectorServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
