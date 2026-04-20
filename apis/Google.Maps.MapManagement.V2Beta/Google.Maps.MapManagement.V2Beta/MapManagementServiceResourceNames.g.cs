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
using gmmv = Google.Maps.MapManagement.V2Beta;
using sys = System;

namespace Google.Maps.MapManagement.V2Beta
{
    /// <summary>Resource name for the <c>MapConfig</c> resource.</summary>
    public sealed partial class MapConfigName : gax::IResourceName, sys::IEquatable<MapConfigName>
    {
        /// <summary>The possible contents of <see cref="MapConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/mapConfigs/{map_config}</c>.</summary>
            ProjectMapConfig = 1,
        }

        private static gax::PathTemplate s_projectMapConfig = new gax::PathTemplate("projects/{project}/mapConfigs/{map_config}");

        /// <summary>Creates a <see cref="MapConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MapConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MapConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MapConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MapConfigName"/> with the pattern <c>projects/{project}/mapConfigs/{map_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MapConfigName"/> constructed from the provided ids.</returns>
        public static MapConfigName FromProjectMapConfig(string projectId, string mapConfigId) =>
            new MapConfigName(ResourceNameType.ProjectMapConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), mapConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MapConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MapConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}</c>.
        /// </returns>
        public static string Format(string projectId, string mapConfigId) => FormatProjectMapConfig(projectId, mapConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MapConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MapConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}</c>.
        /// </returns>
        public static string FormatProjectMapConfig(string projectId, string mapConfigId) =>
            s_projectMapConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="MapConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/mapConfigs/{map_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mapConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MapConfigName"/> if successful.</returns>
        public static MapConfigName Parse(string mapConfigName) => Parse(mapConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MapConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/mapConfigs/{map_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mapConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MapConfigName"/> if successful.</returns>
        public static MapConfigName Parse(string mapConfigName, bool allowUnparsed) =>
            TryParse(mapConfigName, allowUnparsed, out MapConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MapConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/mapConfigs/{map_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mapConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MapConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mapConfigName, out MapConfigName result) => TryParse(mapConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MapConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/mapConfigs/{map_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mapConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MapConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mapConfigName, bool allowUnparsed, out MapConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(mapConfigName, nameof(mapConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMapConfig.TryParseName(mapConfigName, out resourceName))
            {
                result = FromProjectMapConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mapConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MapConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string mapConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MapConfigId = mapConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MapConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/mapConfigs/{map_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public MapConfigName(string projectId, string mapConfigId) : this(ResourceNameType.ProjectMapConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), mapConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)))
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
        /// The <c>MapConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MapConfigId { get; }

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
                case ResourceNameType.ProjectMapConfig: return s_projectMapConfig.Expand(ProjectId, MapConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MapConfigName);

        /// <inheritdoc/>
        public bool Equals(MapConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MapConfigName a, MapConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MapConfigName a, MapConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>StyleConfig</c> resource.</summary>
    public sealed partial class StyleConfigName : gax::IResourceName, sys::IEquatable<StyleConfigName>
    {
        /// <summary>The possible contents of <see cref="StyleConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/styleConfigs/{style_config}</c>.</summary>
            ProjectStyleConfig = 1,
        }

        private static gax::PathTemplate s_projectStyleConfig = new gax::PathTemplate("projects/{project}/styleConfigs/{style_config}");

        /// <summary>Creates a <see cref="StyleConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StyleConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StyleConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StyleConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StyleConfigName"/> with the pattern <c>projects/{project}/styleConfigs/{style_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="styleConfigId">The <c>StyleConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StyleConfigName"/> constructed from the provided ids.</returns>
        public static StyleConfigName FromProjectStyleConfig(string projectId, string styleConfigId) =>
            new StyleConfigName(ResourceNameType.ProjectStyleConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), styleConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(styleConfigId, nameof(styleConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StyleConfigName"/> with pattern
        /// <c>projects/{project}/styleConfigs/{style_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="styleConfigId">The <c>StyleConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StyleConfigName"/> with pattern
        /// <c>projects/{project}/styleConfigs/{style_config}</c>.
        /// </returns>
        public static string Format(string projectId, string styleConfigId) =>
            FormatProjectStyleConfig(projectId, styleConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StyleConfigName"/> with pattern
        /// <c>projects/{project}/styleConfigs/{style_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="styleConfigId">The <c>StyleConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StyleConfigName"/> with pattern
        /// <c>projects/{project}/styleConfigs/{style_config}</c>.
        /// </returns>
        public static string FormatProjectStyleConfig(string projectId, string styleConfigId) =>
            s_projectStyleConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(styleConfigId, nameof(styleConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="StyleConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/styleConfigs/{style_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="styleConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StyleConfigName"/> if successful.</returns>
        public static StyleConfigName Parse(string styleConfigName) => Parse(styleConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StyleConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/styleConfigs/{style_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="styleConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StyleConfigName"/> if successful.</returns>
        public static StyleConfigName Parse(string styleConfigName, bool allowUnparsed) =>
            TryParse(styleConfigName, allowUnparsed, out StyleConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StyleConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/styleConfigs/{style_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="styleConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StyleConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string styleConfigName, out StyleConfigName result) =>
            TryParse(styleConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StyleConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/styleConfigs/{style_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="styleConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StyleConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string styleConfigName, bool allowUnparsed, out StyleConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(styleConfigName, nameof(styleConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectStyleConfig.TryParseName(styleConfigName, out resourceName))
            {
                result = FromProjectStyleConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(styleConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StyleConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string styleConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            StyleConfigId = styleConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StyleConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/styleConfigs/{style_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="styleConfigId">The <c>StyleConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public StyleConfigName(string projectId, string styleConfigId) : this(ResourceNameType.ProjectStyleConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), styleConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(styleConfigId, nameof(styleConfigId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>StyleConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StyleConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectStyleConfig: return s_projectStyleConfig.Expand(ProjectId, StyleConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StyleConfigName);

        /// <inheritdoc/>
        public bool Equals(StyleConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StyleConfigName a, StyleConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StyleConfigName a, StyleConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MapContextConfig</c> resource.</summary>
    public sealed partial class MapContextConfigName : gax::IResourceName, sys::IEquatable<MapContextConfigName>
    {
        /// <summary>The possible contents of <see cref="MapContextConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
            /// </summary>
            ProjectMapConfigMapContextConfig = 1,
        }

        private static gax::PathTemplate s_projectMapConfigMapContextConfig = new gax::PathTemplate("projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}");

        /// <summary>Creates a <see cref="MapContextConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MapContextConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MapContextConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MapContextConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MapContextConfigName"/> with the pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapContextConfigId">The <c>MapContextConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MapContextConfigName"/> constructed from the provided ids.</returns>
        public static MapContextConfigName FromProjectMapConfigMapContextConfig(string projectId, string mapConfigId, string mapContextConfigId) =>
            new MapContextConfigName(ResourceNameType.ProjectMapConfigMapContextConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), mapConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)), mapContextConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapContextConfigId, nameof(mapContextConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MapContextConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapContextConfigId">The <c>MapContextConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MapContextConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
        /// </returns>
        public static string Format(string projectId, string mapConfigId, string mapContextConfigId) =>
            FormatProjectMapConfigMapContextConfig(projectId, mapConfigId, mapContextConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MapContextConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapContextConfigId">The <c>MapContextConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MapContextConfigName"/> with pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>.
        /// </returns>
        public static string FormatProjectMapConfigMapContextConfig(string projectId, string mapConfigId, string mapContextConfigId) =>
            s_projectMapConfigMapContextConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mapContextConfigId, nameof(mapContextConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MapContextConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mapContextConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MapContextConfigName"/> if successful.</returns>
        public static MapContextConfigName Parse(string mapContextConfigName) => Parse(mapContextConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MapContextConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mapContextConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MapContextConfigName"/> if successful.</returns>
        public static MapContextConfigName Parse(string mapContextConfigName, bool allowUnparsed) =>
            TryParse(mapContextConfigName, allowUnparsed, out MapContextConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MapContextConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mapContextConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MapContextConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mapContextConfigName, out MapContextConfigName result) =>
            TryParse(mapContextConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MapContextConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mapContextConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MapContextConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mapContextConfigName, bool allowUnparsed, out MapContextConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(mapContextConfigName, nameof(mapContextConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMapConfigMapContextConfig.TryParseName(mapContextConfigName, out resourceName))
            {
                result = FromProjectMapConfigMapContextConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mapContextConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MapContextConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string mapConfigId = null, string mapContextConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MapConfigId = mapConfigId;
            MapContextConfigId = mapContextConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MapContextConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/mapConfigs/{map_config}/mapContextConfigs/{map_context_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapConfigId">The <c>MapConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mapContextConfigId">The <c>MapContextConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public MapContextConfigName(string projectId, string mapConfigId, string mapContextConfigId) : this(ResourceNameType.ProjectMapConfigMapContextConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), mapConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapConfigId, nameof(mapConfigId)), mapContextConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(mapContextConfigId, nameof(mapContextConfigId)))
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
        /// The <c>MapConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MapConfigId { get; }

        /// <summary>
        /// The <c>MapContextConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MapContextConfigId { get; }

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
                case ResourceNameType.ProjectMapConfigMapContextConfig: return s_projectMapConfigMapContextConfig.Expand(ProjectId, MapConfigId, MapContextConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MapContextConfigName);

        /// <inheritdoc/>
        public bool Equals(MapContextConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MapContextConfigName a, MapContextConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MapContextConfigName a, MapContextConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/datasets/{dataset}</c>.</summary>
            ProjectDataset = 1,
        }

        private static gax::PathTemplate s_projectDataset = new gax::PathTemplate("projects/{project}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectDataset(string projectId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId) => FormatProjectDataset(projectId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectDataset(string projectId, string datasetId) =>
            s_projectDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/datasets/{dataset}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectDataset(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string datasetId) : this(ResourceNameType.ProjectDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

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
                case ResourceNameType.ProjectDataset: return s_projectDataset.Expand(ProjectId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    public partial class CreateMapConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMapConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::MapConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapConfigName MapConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMapConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMapConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::MapConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapConfigName MapConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MapConfig
    {
        /// <summary>
        /// <see cref="gmmv::MapConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapConfigName MapConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StyleConfig
    {
        /// <summary>
        /// <see cref="gmmv::StyleConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::StyleConfigName StyleConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::StyleConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateStyleConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetStyleConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::StyleConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::StyleConfigName StyleConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::StyleConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStyleConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteStyleConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::StyleConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::StyleConfigName StyleConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::StyleConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MapContextConfig
    {
        /// <summary>
        /// <see cref="gmmv::MapContextConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapContextConfigName MapContextConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapContextConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MapConfigName"/>-typed view over the <see cref="MapConfig"/> resource name property.
        /// </summary>
        public MapConfigName MapConfigAsMapConfigName
        {
            get => string.IsNullOrEmpty(MapConfig) ? null : MapConfigName.Parse(MapConfig, allowUnparsed: true);
            set => MapConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="StyleConfigName"/>-typed view over the <see cref="StyleConfig"/> resource name property.
        /// </summary>
        public StyleConfigName StyleConfigAsStyleConfigName
        {
            get => string.IsNullOrEmpty(StyleConfig) ? null : StyleConfigName.Parse(StyleConfig, allowUnparsed: true);
            set => StyleConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DatasetName> DatasetAsDatasetNames
        {
            get => new gax::ResourceNameList<DatasetName>(Dataset, s => string.IsNullOrEmpty(s) ? null : DatasetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreateMapContextConfigRequest
    {
        /// <summary>
        /// <see cref="MapConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MapConfigName ParentAsMapConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MapConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMapContextConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::MapContextConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapContextConfigName MapContextConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapContextConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMapContextConfigsRequest
    {
        /// <summary>
        /// <see cref="MapConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MapConfigName ParentAsMapConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MapConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMapContextConfigRequest
    {
        /// <summary>
        /// <see cref="gmmv::MapContextConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gmmv::MapContextConfigName MapContextConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gmmv::MapContextConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
