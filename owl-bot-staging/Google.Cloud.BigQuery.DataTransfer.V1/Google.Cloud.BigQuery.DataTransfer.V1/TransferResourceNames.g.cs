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
using gcbdv = Google.Cloud.BigQuery.DataTransfer.V1;
using sys = System;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>Resource name for the <c>TransferConfig</c> resource.</summary>
    public sealed partial class TransferConfigName : gax::IResourceName, sys::IEquatable<TransferConfigName>
    {
        /// <summary>The possible contents of <see cref="TransferConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/transferConfigs/{transfer_config}</c>.
            /// </summary>
            ProjectTransferConfig = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c>.
            /// </summary>
            ProjectLocationTransferConfig = 2,
        }

        private static gax::PathTemplate s_projectTransferConfig = new gax::PathTemplate("projects/{project}/transferConfigs/{transfer_config}");

        private static gax::PathTemplate s_projectLocationTransferConfig = new gax::PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}");

        /// <summary>Creates a <see cref="TransferConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TransferConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TransferConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TransferConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TransferConfigName"/> with the pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TransferConfigName"/> constructed from the provided ids.</returns>
        public static TransferConfigName FromProjectTransferConfig(string projectId, string transferConfigId) =>
            new TransferConfigName(ResourceNameType.ProjectTransferConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Creates a <see cref="TransferConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TransferConfigName"/> constructed from the provided ids.</returns>
        public static TransferConfigName FromProjectLocationTransferConfig(string projectId, string locationId, string transferConfigId) =>
            new TransferConfigName(ResourceNameType.ProjectLocationTransferConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>.
        /// </returns>
        public static string Format(string projectId, string transferConfigId) =>
            FormatProjectTransferConfig(projectId, transferConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>.
        /// </returns>
        public static string FormatProjectTransferConfig(string projectId, string transferConfigId) =>
            s_projectTransferConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TransferConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c>.
        /// </returns>
        public static string FormatProjectLocationTransferConfig(string projectId, string locationId, string transferConfigId) =>
            s_projectLocationTransferConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/transferConfigs/{transfer_config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transferConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransferConfigName"/> if successful.</returns>
        public static TransferConfigName Parse(string transferConfigName) => Parse(transferConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TransferConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/transferConfigs/{transfer_config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transferConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TransferConfigName"/> if successful.</returns>
        public static TransferConfigName Parse(string transferConfigName, bool allowUnparsed) =>
            TryParse(transferConfigName, allowUnparsed, out TransferConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/transferConfigs/{transfer_config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="transferConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransferConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transferConfigName, out TransferConfigName result) =>
            TryParse(transferConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TransferConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/transferConfigs/{transfer_config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="transferConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TransferConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transferConfigName, bool allowUnparsed, out TransferConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(transferConfigName, nameof(transferConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTransferConfig.TryParseName(transferConfigName, out resourceName))
            {
                result = FromProjectTransferConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationTransferConfig.TryParseName(transferConfigName, out resourceName))
            {
                result = FromProjectLocationTransferConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(transferConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TransferConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string transferConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TransferConfigId = transferConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TransferConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public TransferConfigName(string projectId, string transferConfigId) : this(ResourceNameType.ProjectTransferConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TransferConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string TransferConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTransferConfig: return s_projectTransferConfig.Expand(ProjectId, TransferConfigId);
                case ResourceNameType.ProjectLocationTransferConfig: return s_projectLocationTransferConfig.Expand(ProjectId, LocationId, TransferConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TransferConfigName);

        /// <inheritdoc/>
        public bool Equals(TransferConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TransferConfigName a, TransferConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TransferConfigName a, TransferConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Run</c> resource.</summary>
    public sealed partial class RunName : gax::IResourceName, sys::IEquatable<RunName>
    {
        /// <summary>The possible contents of <see cref="RunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
            /// </summary>
            ProjectTransferConfigRun = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>.
            /// </summary>
            ProjectLocationTransferConfigRun = 2,
        }

        private static gax::PathTemplate s_projectTransferConfigRun = new gax::PathTemplate("projects/{project}/transferConfigs/{transfer_config}/runs/{run}");

        private static gax::PathTemplate s_projectLocationTransferConfigRun = new gax::PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>Creates a <see cref="RunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RunName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RunName"/> with the pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RunName"/> constructed from the provided ids.</returns>
        public static RunName FromProjectTransferConfigRun(string projectId, string transferConfigId, string runId) =>
            new RunName(ResourceNameType.ProjectTransferConfigRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Creates a <see cref="RunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RunName"/> constructed from the provided ids.</returns>
        public static RunName FromProjectLocationTransferConfigRun(string projectId, string locationId, string transferConfigId, string runId) =>
            new RunName(ResourceNameType.ProjectLocationTransferConfigRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </returns>
        public static string Format(string projectId, string transferConfigId, string runId) =>
            FormatProjectTransferConfigRun(projectId, transferConfigId, runId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </returns>
        public static string FormatProjectTransferConfigRun(string projectId, string transferConfigId, string runId) =>
            s_projectTransferConfigRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>.
        /// </returns>
        public static string FormatProjectLocationTransferConfigRun(string projectId, string locationId, string transferConfigId, string runId) =>
            s_projectLocationTransferConfigRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>Parses the given resource name string into a new <see cref="RunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RunName"/> if successful.</returns>
        public static RunName Parse(string runName) => Parse(runName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RunName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RunName"/> if successful.</returns>
        public static RunName Parse(string runName, bool allowUnparsed) =>
            TryParse(runName, allowUnparsed, out RunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="RunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runName, out RunName result) => TryParse(runName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RunName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runName, bool allowUnparsed, out RunName result)
        {
            gax::GaxPreconditions.CheckNotNull(runName, nameof(runName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTransferConfigRun.TryParseName(runName, out resourceName))
            {
                result = FromProjectTransferConfigRun(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationTransferConfigRun.TryParseName(runName, out resourceName))
            {
                result = FromProjectLocationTransferConfigRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(runName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string runId = null, string transferConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RunId = runId;
            TransferConfigId = transferConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RunName"/> class from the component parts of pattern
        /// <c>projects/{project}/transferConfigs/{transfer_config}/runs/{run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="transferConfigId">The <c>TransferConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        public RunName(string projectId, string transferConfigId, string runId) : this(ResourceNameType.ProjectTransferConfigRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), transferConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(transferConfigId, nameof(transferConfigId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Run</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RunId { get; }

        /// <summary>
        /// The <c>TransferConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string TransferConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTransferConfigRun: return s_projectTransferConfigRun.Expand(ProjectId, TransferConfigId, RunId);
                case ResourceNameType.ProjectLocationTransferConfigRun: return s_projectLocationTransferConfigRun.Expand(ProjectId, LocationId, TransferConfigId, RunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RunName);

        /// <inheritdoc/>
        public bool Equals(RunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RunName a, RunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RunName a, RunName b) => !(a == b);
    }

    public partial class TransferConfig
    {
        /// <summary>
        /// <see cref="gcbdv::TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::TransferConfigName TransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::TransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TransferRun
    {
        /// <summary>
        /// <see cref="gcbdv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
