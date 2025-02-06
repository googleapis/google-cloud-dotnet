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
using gax = Google.Api.Gax;
using gcmv = Google.Cloud.Monitoring.V3;
using sys = System;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Resource name for the <c>UptimeCheckConfig</c> resource.</summary>
    public sealed partial class UptimeCheckConfigName : gax::IResourceName, sys::IEquatable<UptimeCheckConfigName>
    {
        /// <summary>The possible contents of <see cref="UptimeCheckConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
            /// </summary>
            ProjectUptimeCheckConfig = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c>
            /// .
            /// </summary>
            OrganizationUptimeCheckConfig = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c>.
            /// </summary>
            FolderUptimeCheckConfig = 3,
        }

        private static gax::PathTemplate s_projectUptimeCheckConfig = new gax::PathTemplate("projects/{project}/uptimeCheckConfigs/{uptime_check_config}");

        private static gax::PathTemplate s_organizationUptimeCheckConfig = new gax::PathTemplate("organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}");

        private static gax::PathTemplate s_folderUptimeCheckConfig = new gax::PathTemplate("folders/{folder}/uptimeCheckConfigs/{uptime_check_config}");

        /// <summary>Creates a <see cref="UptimeCheckConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UptimeCheckConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UptimeCheckConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UptimeCheckConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UptimeCheckConfigName"/> with the pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UptimeCheckConfigName"/> constructed from the provided ids.</returns>
        public static UptimeCheckConfigName FromProjectUptimeCheckConfig(string projectId, string uptimeCheckConfigId) =>
            new UptimeCheckConfigName(ResourceNameType.ProjectUptimeCheckConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), uptimeCheckConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Creates a <see cref="UptimeCheckConfigName"/> with the pattern
        /// <c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UptimeCheckConfigName"/> constructed from the provided ids.</returns>
        public static UptimeCheckConfigName FromOrganizationUptimeCheckConfig(string organizationId, string uptimeCheckConfigId) =>
            new UptimeCheckConfigName(ResourceNameType.OrganizationUptimeCheckConfig, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), uptimeCheckConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Creates a <see cref="UptimeCheckConfigName"/> with the pattern
        /// <c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UptimeCheckConfigName"/> constructed from the provided ids.</returns>
        public static UptimeCheckConfigName FromFolderUptimeCheckConfig(string folderId, string uptimeCheckConfigId) =>
            new UptimeCheckConfigName(ResourceNameType.FolderUptimeCheckConfig, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), uptimeCheckConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </returns>
        public static string Format(string projectId, string uptimeCheckConfigId) =>
            FormatProjectUptimeCheckConfig(projectId, uptimeCheckConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </returns>
        public static string FormatProjectUptimeCheckConfig(string projectId, string uptimeCheckConfigId) =>
            s_projectUptimeCheckConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </returns>
        public static string FormatOrganizationUptimeCheckConfig(string organizationId, string uptimeCheckConfigId) =>
            s_organizationUptimeCheckConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UptimeCheckConfigName"/> with pattern
        /// <c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c>.
        /// </returns>
        public static string FormatFolderUptimeCheckConfig(string folderId, string uptimeCheckConfigId) =>
            s_folderUptimeCheckConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UptimeCheckConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="uptimeCheckConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UptimeCheckConfigName"/> if successful.</returns>
        public static UptimeCheckConfigName Parse(string uptimeCheckConfigName) => Parse(uptimeCheckConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UptimeCheckConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="uptimeCheckConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UptimeCheckConfigName"/> if successful.</returns>
        public static UptimeCheckConfigName Parse(string uptimeCheckConfigName, bool allowUnparsed) =>
            TryParse(uptimeCheckConfigName, allowUnparsed, out UptimeCheckConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UptimeCheckConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="uptimeCheckConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UptimeCheckConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string uptimeCheckConfigName, out UptimeCheckConfigName result) =>
            TryParse(uptimeCheckConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UptimeCheckConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/uptimeCheckConfigs/{uptime_check_config}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/uptimeCheckConfigs/{uptime_check_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="uptimeCheckConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UptimeCheckConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string uptimeCheckConfigName, bool allowUnparsed, out UptimeCheckConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(uptimeCheckConfigName, nameof(uptimeCheckConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectUptimeCheckConfig.TryParseName(uptimeCheckConfigName, out resourceName))
            {
                result = FromProjectUptimeCheckConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationUptimeCheckConfig.TryParseName(uptimeCheckConfigName, out resourceName))
            {
                result = FromOrganizationUptimeCheckConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderUptimeCheckConfig.TryParseName(uptimeCheckConfigName, out resourceName))
            {
                result = FromFolderUptimeCheckConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(uptimeCheckConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UptimeCheckConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string organizationId = null, string projectId = null, string uptimeCheckConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            UptimeCheckConfigId = uptimeCheckConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UptimeCheckConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/uptimeCheckConfigs/{uptime_check_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uptimeCheckConfigId">The <c>UptimeCheckConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public UptimeCheckConfigName(string projectId, string uptimeCheckConfigId) : this(ResourceNameType.ProjectUptimeCheckConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), uptimeCheckConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(uptimeCheckConfigId, nameof(uptimeCheckConfigId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>UptimeCheckConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string UptimeCheckConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectUptimeCheckConfig: return s_projectUptimeCheckConfig.Expand(ProjectId, UptimeCheckConfigId);
                case ResourceNameType.OrganizationUptimeCheckConfig: return s_organizationUptimeCheckConfig.Expand(OrganizationId, UptimeCheckConfigId);
                case ResourceNameType.FolderUptimeCheckConfig: return s_folderUptimeCheckConfig.Expand(FolderId, UptimeCheckConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UptimeCheckConfigName);

        /// <inheritdoc/>
        public bool Equals(UptimeCheckConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UptimeCheckConfigName a, UptimeCheckConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UptimeCheckConfigName a, UptimeCheckConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Function</c> resource.</summary>
    public sealed partial class FunctionName : gax::IResourceName, sys::IEquatable<FunctionName>
    {
        /// <summary>The possible contents of <see cref="FunctionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/functions/{function}</c>.
            /// </summary>
            ProjectLocationFunction = 1,
        }

        private static gax::PathTemplate s_projectLocationFunction = new gax::PathTemplate("projects/{project}/locations/{location}/functions/{function}");

        /// <summary>Creates a <see cref="FunctionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FunctionName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static FunctionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FunctionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FunctionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FunctionName"/> constructed from the provided ids.</returns>
        public static FunctionName FromProjectLocationFunction(string projectId, string locationId, string functionId) =>
            new FunctionName(ResourceNameType.ProjectLocationFunction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), functionId: gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string functionId) =>
            FormatProjectLocationFunction(projectId, locationId, functionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FunctionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>.
        /// </returns>
        public static string FormatProjectLocationFunction(string projectId, string locationId, string functionId) =>
            s_projectLocationFunction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)));

        /// <summary>Parses the given resource name string into a new <see cref="FunctionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="functionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FunctionName"/> if successful.</returns>
        public static FunctionName Parse(string functionName) => Parse(functionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FunctionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="functionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FunctionName"/> if successful.</returns>
        public static FunctionName Parse(string functionName, bool allowUnparsed) =>
            TryParse(functionName, allowUnparsed, out FunctionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FunctionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="functionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FunctionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string functionName, out FunctionName result) => TryParse(functionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FunctionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/functions/{function}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="functionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FunctionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string functionName, bool allowUnparsed, out FunctionName result)
        {
            gax::GaxPreconditions.CheckNotNull(functionName, nameof(functionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFunction.TryParseName(functionName, out resourceName))
            {
                result = FromProjectLocationFunction(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(functionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FunctionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string functionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FunctionId = functionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FunctionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/functions/{function}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="functionId">The <c>Function</c> ID. Must not be <c>null</c> or empty.</param>
        public FunctionName(string projectId, string locationId, string functionId) : this(ResourceNameType.ProjectLocationFunction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), functionId: gax::GaxPreconditions.CheckNotNullOrEmpty(functionId, nameof(functionId)))
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
        /// The <c>Function</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FunctionId { get; }

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
                case ResourceNameType.ProjectLocationFunction: return s_projectLocationFunction.Expand(ProjectId, LocationId, FunctionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FunctionName);

        /// <inheritdoc/>
        public bool Equals(FunctionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FunctionName a, FunctionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FunctionName a, FunctionName b) => !(a == b);
    }

    public partial class SyntheticMonitorTarget
    {
        public partial class Types
        {
            public partial class CloudFunctionV2Target
            {
                /// <summary>
                /// <see cref="gcmv::FunctionName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gcmv::FunctionName FunctionName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcmv::FunctionName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class UptimeCheckConfig
    {
        /// <summary>
        /// <see cref="gcmv::UptimeCheckConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::UptimeCheckConfigName UptimeCheckConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::UptimeCheckConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::UptimeCheckConfigName.TryParse(Name, out gcmv::UptimeCheckConfigName uptimeCheckConfig))
                {
                    return uptimeCheckConfig;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }
}
