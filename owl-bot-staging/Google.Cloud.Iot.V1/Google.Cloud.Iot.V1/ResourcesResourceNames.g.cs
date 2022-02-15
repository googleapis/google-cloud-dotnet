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

using gax = Google.Api.Gax;
using gciv = Google.Cloud.Iot.V1;
using sys = System;

namespace Google.Cloud.Iot.V1
{
    /// <summary>Resource name for the <c>Device</c> resource.</summary>
    public sealed partial class DeviceName : gax::IResourceName, sys::IEquatable<DeviceName>
    {
        /// <summary>The possible contents of <see cref="DeviceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
            /// </summary>
            ProjectLocationRegistryDevice = 1,
        }

        private static gax::PathTemplate s_projectLocationRegistryDevice = new gax::PathTemplate("projects/{project}/locations/{location}/registries/{registry}/devices/{device}");

        /// <summary>Creates a <see cref="DeviceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeviceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeviceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeviceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeviceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceId">The <c>Device</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeviceName"/> constructed from the provided ids.</returns>
        public static DeviceName FromProjectLocationRegistryDevice(string projectId, string locationId, string registryId, string deviceId) =>
            new DeviceName(ResourceNameType.ProjectLocationRegistryDevice, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registryId: gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)), deviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceId">The <c>Device</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string registryId, string deviceId) =>
            FormatProjectLocationRegistryDevice(projectId, locationId, registryId, deviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeviceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceId">The <c>Device</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeviceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>.
        /// </returns>
        public static string FormatProjectLocationRegistryDevice(string projectId, string locationId, string registryId, string deviceId) =>
            s_projectLocationRegistryDevice.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeviceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeviceName"/> if successful.</returns>
        public static DeviceName Parse(string deviceName) => Parse(deviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeviceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeviceName"/> if successful.</returns>
        public static DeviceName Parse(string deviceName, bool allowUnparsed) =>
            TryParse(deviceName, allowUnparsed, out DeviceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceName, out DeviceName result) => TryParse(deviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeviceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeviceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deviceName, bool allowUnparsed, out DeviceName result)
        {
            gax::GaxPreconditions.CheckNotNull(deviceName, nameof(deviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRegistryDevice.TryParseName(deviceName, out resourceName))
            {
                result = FromProjectLocationRegistryDevice(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeviceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deviceId = null, string locationId = null, string projectId = null, string registryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeviceId = deviceId;
            LocationId = locationId;
            ProjectId = projectId;
            RegistryId = registryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeviceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}/devices/{device}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deviceId">The <c>Device</c> ID. Must not be <c>null</c> or empty.</param>
        public DeviceName(string projectId, string locationId, string registryId, string deviceId) : this(ResourceNameType.ProjectLocationRegistryDevice, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registryId: gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)), deviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(deviceId, nameof(deviceId)))
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
        /// The <c>Device</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeviceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Registry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegistryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRegistryDevice: return s_projectLocationRegistryDevice.Expand(ProjectId, LocationId, RegistryId, DeviceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeviceName);

        /// <inheritdoc/>
        public bool Equals(DeviceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DeviceName a, DeviceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DeviceName a, DeviceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Registry</c> resource.</summary>
    public sealed partial class RegistryName : gax::IResourceName, sys::IEquatable<RegistryName>
    {
        /// <summary>The possible contents of <see cref="RegistryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/registries/{registry}</c>.
            /// </summary>
            ProjectLocationRegistry = 1,
        }

        private static gax::PathTemplate s_projectLocationRegistry = new gax::PathTemplate("projects/{project}/locations/{location}/registries/{registry}");

        /// <summary>Creates a <see cref="RegistryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegistryName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static RegistryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegistryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegistryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegistryName"/> constructed from the provided ids.</returns>
        public static RegistryName FromProjectLocationRegistry(string projectId, string locationId, string registryId) =>
            new RegistryName(ResourceNameType.ProjectLocationRegistry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registryId: gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegistryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegistryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string registryId) =>
            FormatProjectLocationRegistry(projectId, locationId, registryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegistryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegistryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>.
        /// </returns>
        public static string FormatProjectLocationRegistry(string projectId, string locationId, string registryId) =>
            s_projectLocationRegistry.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RegistryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registries/{registry}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="registryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegistryName"/> if successful.</returns>
        public static RegistryName Parse(string registryName) => Parse(registryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegistryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registries/{registry}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="registryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegistryName"/> if successful.</returns>
        public static RegistryName Parse(string registryName, bool allowUnparsed) =>
            TryParse(registryName, allowUnparsed, out RegistryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegistryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registries/{registry}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="registryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegistryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string registryName, out RegistryName result) => TryParse(registryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegistryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/registries/{registry}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="registryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegistryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string registryName, bool allowUnparsed, out RegistryName result)
        {
            gax::GaxPreconditions.CheckNotNull(registryName, nameof(registryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRegistry.TryParseName(registryName, out resourceName))
            {
                result = FromProjectLocationRegistry(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(registryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegistryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string registryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RegistryId = registryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegistryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/registries/{registry}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="registryId">The <c>Registry</c> ID. Must not be <c>null</c> or empty.</param>
        public RegistryName(string projectId, string locationId, string registryId) : this(ResourceNameType.ProjectLocationRegistry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), registryId: gax::GaxPreconditions.CheckNotNullOrEmpty(registryId, nameof(registryId)))
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
        /// The <c>Registry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegistryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRegistry: return s_projectLocationRegistry.Expand(ProjectId, LocationId, RegistryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegistryName);

        /// <inheritdoc/>
        public bool Equals(RegistryName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RegistryName a, RegistryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RegistryName a, RegistryName b) => !(a == b);
    }

    public partial class Device
    {
        /// <summary>
        /// <see cref="gciv::DeviceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::DeviceName DeviceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::DeviceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeviceRegistry
    {
        /// <summary>
        /// <see cref="gciv::RegistryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::RegistryName RegistryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::RegistryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
