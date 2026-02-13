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
using gccv = Google.Cloud.Ces.V1;
using sys = System;

namespace Google.Cloud.Ces.V1
{
    /// <summary>Resource name for the <c>Tool</c> resource.</summary>
    public sealed partial class ToolName : gax::IResourceName, sys::IEquatable<ToolName>
    {
        /// <summary>The possible contents of <see cref="ToolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
            /// </summary>
            ProjectLocationAppTool = 1,
        }

        private static gax::PathTemplate s_projectLocationAppTool = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/tools/{tool}");

        /// <summary>Creates a <see cref="ToolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ToolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ToolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ToolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ToolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ToolName"/> constructed from the provided ids.</returns>
        public static ToolName FromProjectLocationAppTool(string projectId, string locationId, string appId, string toolId) =>
            new ToolName(ResourceNameType.ProjectLocationAppTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string toolId) =>
            FormatProjectLocationAppTool(projectId, locationId, appId, toolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>.
        /// </returns>
        public static string FormatProjectLocationAppTool(string projectId, string locationId, string appId, string toolId) =>
            s_projectLocationAppTool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>Parses the given resource name string into a new <see cref="ToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ToolName"/> if successful.</returns>
        public static ToolName Parse(string toolName) => Parse(toolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ToolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ToolName"/> if successful.</returns>
        public static ToolName Parse(string toolName, bool allowUnparsed) =>
            TryParse(toolName, allowUnparsed, out ToolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolName, out ToolName result) => TryParse(toolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolName, bool allowUnparsed, out ToolName result)
        {
            gax::GaxPreconditions.CheckNotNull(toolName, nameof(toolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppTool.TryParseName(toolName, out resourceName))
            {
                result = FromProjectLocationAppTool(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(toolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ToolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string locationId = null, string projectId = null, string toolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            LocationId = locationId;
            ProjectId = projectId;
            ToolId = toolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ToolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/tools/{tool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        public ToolName(string projectId, string locationId, string appId, string toolId) : this(ResourceNameType.ProjectLocationAppTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ToolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAppTool: return s_projectLocationAppTool.Expand(ProjectId, LocationId, AppId, ToolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ToolName);

        /// <inheritdoc/>
        public bool Equals(ToolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ToolName a, ToolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ToolName a, ToolName b) => !(a == b);
    }

    public partial class Tool
    {
        /// <summary>
        /// <see cref="gccv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
