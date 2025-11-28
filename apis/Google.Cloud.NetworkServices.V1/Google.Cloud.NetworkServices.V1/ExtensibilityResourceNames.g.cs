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
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>WasmPlugin</c> resource.</summary>
    public sealed partial class WasmPluginName : gax::IResourceName, sys::IEquatable<WasmPluginName>
    {
        /// <summary>The possible contents of <see cref="WasmPluginName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
            /// </summary>
            ProjectLocationWasmPlugin = 1,
        }

        private static gax::PathTemplate s_projectLocationWasmPlugin = new gax::PathTemplate("projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}");

        /// <summary>Creates a <see cref="WasmPluginName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WasmPluginName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WasmPluginName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WasmPluginName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WasmPluginName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WasmPluginName"/> constructed from the provided ids.</returns>
        public static WasmPluginName FromProjectLocationWasmPlugin(string projectId, string locationId, string wasmPluginId) =>
            new WasmPluginName(ResourceNameType.ProjectLocationWasmPlugin, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), wasmPluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WasmPluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WasmPluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string wasmPluginId) =>
            FormatProjectLocationWasmPlugin(projectId, locationId, wasmPluginId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WasmPluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WasmPluginName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>.
        /// </returns>
        public static string FormatProjectLocationWasmPlugin(string projectId, string locationId, string wasmPluginId) =>
            s_projectLocationWasmPlugin.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)));

        /// <summary>Parses the given resource name string into a new <see cref="WasmPluginName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="wasmPluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WasmPluginName"/> if successful.</returns>
        public static WasmPluginName Parse(string wasmPluginName) => Parse(wasmPluginName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WasmPluginName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="wasmPluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WasmPluginName"/> if successful.</returns>
        public static WasmPluginName Parse(string wasmPluginName, bool allowUnparsed) =>
            TryParse(wasmPluginName, allowUnparsed, out WasmPluginName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WasmPluginName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="wasmPluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WasmPluginName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string wasmPluginName, out WasmPluginName result) =>
            TryParse(wasmPluginName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WasmPluginName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="wasmPluginName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WasmPluginName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string wasmPluginName, bool allowUnparsed, out WasmPluginName result)
        {
            gax::GaxPreconditions.CheckNotNull(wasmPluginName, nameof(wasmPluginName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWasmPlugin.TryParseName(wasmPluginName, out resourceName))
            {
                result = FromProjectLocationWasmPlugin(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(wasmPluginName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WasmPluginName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string wasmPluginId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WasmPluginId = wasmPluginId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WasmPluginName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        public WasmPluginName(string projectId, string locationId, string wasmPluginId) : this(ResourceNameType.ProjectLocationWasmPlugin, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), wasmPluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)))
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
        /// The <c>WasmPlugin</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WasmPluginId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWasmPlugin: return s_projectLocationWasmPlugin.Expand(ProjectId, LocationId, WasmPluginId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WasmPluginName);

        /// <inheritdoc/>
        public bool Equals(WasmPluginName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WasmPluginName a, WasmPluginName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WasmPluginName a, WasmPluginName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WasmPluginVersion</c> resource.</summary>
    public sealed partial class WasmPluginVersionName : gax::IResourceName, sys::IEquatable<WasmPluginVersionName>
    {
        /// <summary>The possible contents of <see cref="WasmPluginVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
            /// </summary>
            ProjectLocationWasmPluginWasmPluginVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationWasmPluginWasmPluginVersion = new gax::PathTemplate("projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}");

        /// <summary>Creates a <see cref="WasmPluginVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WasmPluginVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WasmPluginVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WasmPluginVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WasmPluginVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginVersionId">The <c>WasmPluginVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WasmPluginVersionName"/> constructed from the provided ids.</returns>
        public static WasmPluginVersionName FromProjectLocationWasmPluginWasmPluginVersion(string projectId, string locationId, string wasmPluginId, string wasmPluginVersionId) =>
            new WasmPluginVersionName(ResourceNameType.ProjectLocationWasmPluginWasmPluginVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), wasmPluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)), wasmPluginVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginVersionId, nameof(wasmPluginVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WasmPluginVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginVersionId">The <c>WasmPluginVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WasmPluginVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string wasmPluginId, string wasmPluginVersionId) =>
            FormatProjectLocationWasmPluginWasmPluginVersion(projectId, locationId, wasmPluginId, wasmPluginVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WasmPluginVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginVersionId">The <c>WasmPluginVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WasmPluginVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>.
        /// </returns>
        public static string FormatProjectLocationWasmPluginWasmPluginVersion(string projectId, string locationId, string wasmPluginId, string wasmPluginVersionId) =>
            s_projectLocationWasmPluginWasmPluginVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)), gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginVersionId, nameof(wasmPluginVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WasmPluginVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="wasmPluginVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WasmPluginVersionName"/> if successful.</returns>
        public static WasmPluginVersionName Parse(string wasmPluginVersionName) => Parse(wasmPluginVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WasmPluginVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="wasmPluginVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WasmPluginVersionName"/> if successful.</returns>
        public static WasmPluginVersionName Parse(string wasmPluginVersionName, bool allowUnparsed) =>
            TryParse(wasmPluginVersionName, allowUnparsed, out WasmPluginVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WasmPluginVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="wasmPluginVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WasmPluginVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string wasmPluginVersionName, out WasmPluginVersionName result) =>
            TryParse(wasmPluginVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WasmPluginVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="wasmPluginVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WasmPluginVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string wasmPluginVersionName, bool allowUnparsed, out WasmPluginVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(wasmPluginVersionName, nameof(wasmPluginVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWasmPluginWasmPluginVersion.TryParseName(wasmPluginVersionName, out resourceName))
            {
                result = FromProjectLocationWasmPluginWasmPluginVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(wasmPluginVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WasmPluginVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string wasmPluginId = null, string wasmPluginVersionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WasmPluginId = wasmPluginId;
            WasmPluginVersionId = wasmPluginVersionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WasmPluginVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/wasmPlugins/{wasm_plugin}/versions/{wasm_plugin_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginId">The <c>WasmPlugin</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="wasmPluginVersionId">The <c>WasmPluginVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public WasmPluginVersionName(string projectId, string locationId, string wasmPluginId, string wasmPluginVersionId) : this(ResourceNameType.ProjectLocationWasmPluginWasmPluginVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), wasmPluginId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginId, nameof(wasmPluginId)), wasmPluginVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(wasmPluginVersionId, nameof(wasmPluginVersionId)))
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
        /// The <c>WasmPlugin</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WasmPluginId { get; }

        /// <summary>
        /// The <c>WasmPluginVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string WasmPluginVersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWasmPluginWasmPluginVersion: return s_projectLocationWasmPluginWasmPluginVersion.Expand(ProjectId, LocationId, WasmPluginId, WasmPluginVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WasmPluginVersionName);

        /// <inheritdoc/>
        public bool Equals(WasmPluginVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WasmPluginVersionName a, WasmPluginVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WasmPluginVersionName a, WasmPluginVersionName b) => !(a == b);
    }

    public partial class WasmPlugin
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginName WasmPluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WasmPluginVersion
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginVersionName WasmPluginVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWasmPluginsRequest
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

    public partial class GetWasmPluginRequest
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginName WasmPluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWasmPluginRequest
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

    public partial class DeleteWasmPluginRequest
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginName WasmPluginName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWasmPluginVersionsRequest
    {
        /// <summary>
        /// <see cref="WasmPluginName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WasmPluginName ParentAsWasmPluginName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WasmPluginName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWasmPluginVersionRequest
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginVersionName WasmPluginVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWasmPluginVersionRequest
    {
        /// <summary>
        /// <see cref="WasmPluginName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WasmPluginName ParentAsWasmPluginName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WasmPluginName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWasmPluginVersionRequest
    {
        /// <summary>
        /// <see cref="gcnv::WasmPluginVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::WasmPluginVersionName WasmPluginVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::WasmPluginVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
