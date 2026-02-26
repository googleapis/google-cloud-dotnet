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
using gccv = Google.Cloud.Ces.V1Beta;
using sys = System;

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Resource name for the <c>Toolset</c> resource.</summary>
    public sealed partial class ToolsetName : gax::IResourceName, sys::IEquatable<ToolsetName>
    {
        /// <summary>The possible contents of <see cref="ToolsetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>
            /// .
            /// </summary>
            ProjectLocationAppToolset = 1,
        }

        private static gax::PathTemplate s_projectLocationAppToolset = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}");

        /// <summary>Creates a <see cref="ToolsetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ToolsetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ToolsetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ToolsetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ToolsetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolsetId">The <c>Toolset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ToolsetName"/> constructed from the provided ids.</returns>
        public static ToolsetName FromProjectLocationAppToolset(string projectId, string locationId, string appId, string toolsetId) =>
            new ToolsetName(ResourceNameType.ProjectLocationAppToolset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), toolsetId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolsetId, nameof(toolsetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolsetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolsetId">The <c>Toolset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolsetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string toolsetId) =>
            FormatProjectLocationAppToolset(projectId, locationId, appId, toolsetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolsetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolsetId">The <c>Toolset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolsetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>.
        /// </returns>
        public static string FormatProjectLocationAppToolset(string projectId, string locationId, string appId, string toolsetId) =>
            s_projectLocationAppToolset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(toolsetId, nameof(toolsetId)));

        /// <summary>Parses the given resource name string into a new <see cref="ToolsetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolsetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ToolsetName"/> if successful.</returns>
        public static ToolsetName Parse(string toolsetName) => Parse(toolsetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ToolsetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolsetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ToolsetName"/> if successful.</returns>
        public static ToolsetName Parse(string toolsetName, bool allowUnparsed) =>
            TryParse(toolsetName, allowUnparsed, out ToolsetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolsetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolsetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolsetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolsetName, out ToolsetName result) => TryParse(toolsetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolsetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolsetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolsetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolsetName, bool allowUnparsed, out ToolsetName result)
        {
            gax::GaxPreconditions.CheckNotNull(toolsetName, nameof(toolsetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppToolset.TryParseName(toolsetName, out resourceName))
            {
                result = FromProjectLocationAppToolset(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(toolsetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ToolsetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string locationId = null, string projectId = null, string toolsetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            LocationId = locationId;
            ProjectId = projectId;
            ToolsetId = toolsetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ToolsetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/toolsets/{toolset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolsetId">The <c>Toolset</c> ID. Must not be <c>null</c> or empty.</param>
        public ToolsetName(string projectId, string locationId, string appId, string toolsetId) : this(ResourceNameType.ProjectLocationAppToolset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), toolsetId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolsetId, nameof(toolsetId)))
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
        /// The <c>Toolset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ToolsetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAppToolset: return s_projectLocationAppToolset.Expand(ProjectId, LocationId, AppId, ToolsetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ToolsetName);

        /// <inheritdoc/>
        public bool Equals(ToolsetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ToolsetName a, ToolsetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ToolsetName a, ToolsetName b) => !(a == b);
    }

    public partial class Toolset
    {
        /// <summary>
        /// <see cref="gccv::ToolsetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ToolsetName ToolsetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ToolsetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
