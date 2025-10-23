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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
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
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tools/{tool}</c>.
            /// </summary>
            ProjectLocationTool = 1,
        }

        private static gax::PathTemplate s_projectLocationTool = new gax::PathTemplate("projects/{project}/locations/{location}/tools/{tool}");

        /// <summary>Creates a <see cref="ToolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ToolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ToolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ToolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ToolName"/> with the pattern <c>projects/{project}/locations/{location}/tools/{tool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ToolName"/> constructed from the provided ids.</returns>
        public static ToolName FromProjectLocationTool(string projectId, string locationId, string toolId) =>
            new ToolName(ResourceNameType.ProjectLocationTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tools/{tool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string toolId) =>
            FormatProjectLocationTool(projectId, locationId, toolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tools/{tool}</c>.
        /// </returns>
        public static string FormatProjectLocationTool(string projectId, string locationId, string toolId) =>
            s_projectLocationTool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>Parses the given resource name string into a new <see cref="ToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/tools/{tool}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/{location}/tools/{tool}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/{location}/tools/{tool}</c></description></item>
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
        /// <item><description><c>projects/{project}/locations/{location}/tools/{tool}</c></description></item>
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
            if (s_projectLocationTool.TryParseName(toolName, out resourceName))
            {
                result = FromProjectLocationTool(resourceName[0], resourceName[1], resourceName[2]);
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

        private ToolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string toolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ToolId = toolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ToolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tools/{tool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        public ToolName(string projectId, string locationId, string toolId) : this(ResourceNameType.ProjectLocationTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)))
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
                case ResourceNameType.ProjectLocationTool: return s_projectLocationTool.Expand(ProjectId, LocationId, ToolId);
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

    /// <summary>Resource name for the <c>SecretVersion</c> resource.</summary>
    public sealed partial class SecretVersionName : gax::IResourceName, sys::IEquatable<SecretVersionName>
    {
        /// <summary>The possible contents of <see cref="SecretVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
            /// </summary>
            ProjectSecretVersion = 1,
        }

        private static gax::PathTemplate s_projectSecretVersion = new gax::PathTemplate("projects/{project}/secrets/{secret}/versions/{version}");

        /// <summary>Creates a <see cref="SecretVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretVersionName"/> with the pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretVersionName"/> constructed from the provided ids.</returns>
        public static SecretVersionName FromProjectSecretVersion(string projectId, string secretId, string versionId) =>
            new SecretVersionName(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId, string versionId) =>
            FormatProjectSecretVersion(projectId, secretId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectSecretVersion(string projectId, string secretId, string versionId) =>
            s_projectSecretVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName) => Parse(secretVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName, bool allowUnparsed) =>
            TryParse(secretVersionName, allowUnparsed, out SecretVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, out SecretVersionName result) =>
            TryParse(secretVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, bool allowUnparsed, out SecretVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecretVersion.TryParseName(secretVersionName, out resourceName))
            {
                result = FromProjectSecretVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretVersionName(string projectId, string secretId, string versionId) : this(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSecretVersion: return s_projectSecretVersion.Expand(ProjectId, SecretId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretVersionName);

        /// <inheritdoc/>
        public bool Equals(SecretVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecretVersionName a, SecretVersionName b) => !(a == b);
    }

    public partial class CreateToolRequest
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

    public partial class GetToolRequest
    {
        /// <summary>
        /// <see cref="gcdv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListToolsRequest
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

    public partial class DeleteToolRequest
    {
        /// <summary>
        /// <see cref="gcdv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Tool
    {
        /// <summary>
        /// <see cref="gcdv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Authentication
            {
                public partial class Types
                {
                    public partial class ApiKeyConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SecretVersionForApiKey"/>
                        /// resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForApiKeyAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForApiKey) ? null : SecretVersionName.Parse(SecretVersionForApiKey, allowUnparsed: true);
                            set => SecretVersionForApiKey = value?.ToString() ?? "";
                        }
                    }

                    public partial class OAuthConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the
                        /// <see cref="SecretVersionForClientSecret"/> resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForClientSecretAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForClientSecret) ? null : SecretVersionName.Parse(SecretVersionForClientSecret, allowUnparsed: true);
                            set => SecretVersionForClientSecret = value?.ToString() ?? "";
                        }
                    }

                    public partial class BearerTokenConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SecretVersionForToken"/>
                        /// resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForTokenAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForToken) ? null : SecretVersionName.Parse(SecretVersionForToken, allowUnparsed: true);
                            set => SecretVersionForToken = value?.ToString() ?? "";
                        }
                    }
                }
            }

            public partial class ServiceDirectoryConfig
            {
                /// <summary>
                /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
                /// </summary>
                public ServiceName ServiceAsServiceName
                {
                    get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
                    set => Service = value?.ToString() ?? "";
                }
            }
        }
    }
}
