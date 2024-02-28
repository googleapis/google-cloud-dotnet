// Copyright 2024 Google LLC
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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>Execution</c> resource.</summary>
    public sealed partial class ExecutionName : gax::IResourceName, sys::IEquatable<ExecutionName>
    {
        /// <summary>The possible contents of <see cref="ExecutionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
            /// </summary>
            ProjectLocationMetadataStoreExecution = 1,
        }

        private static gax::PathTemplate s_projectLocationMetadataStoreExecution = new gax::PathTemplate("projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}");

        /// <summary>Creates a <see cref="ExecutionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExecutionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExecutionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExecutionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExecutionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExecutionName"/> constructed from the provided ids.</returns>
        public static ExecutionName FromProjectLocationMetadataStoreExecution(string projectId, string locationId, string metadataStoreId, string executionId) =>
            new ExecutionName(ResourceNameType.ProjectLocationMetadataStoreExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string metadataStoreId, string executionId) =>
            FormatProjectLocationMetadataStoreExecution(projectId, locationId, metadataStoreId, executionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExecutionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>.
        /// </returns>
        public static string FormatProjectLocationMetadataStoreExecution(string projectId, string locationId, string metadataStoreId, string executionId) =>
            s_projectLocationMetadataStoreExecution.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExecutionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName) => Parse(executionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExecutionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExecutionName"/> if successful.</returns>
        public static ExecutionName Parse(string executionName, bool allowUnparsed) =>
            TryParse(executionName, allowUnparsed, out ExecutionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, out ExecutionName result) => TryParse(executionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExecutionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="executionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExecutionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string executionName, bool allowUnparsed, out ExecutionName result)
        {
            gax::GaxPreconditions.CheckNotNull(executionName, nameof(executionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMetadataStoreExecution.TryParseName(executionName, out resourceName))
            {
                result = FromProjectLocationMetadataStoreExecution(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(executionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExecutionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string executionId = null, string locationId = null, string metadataStoreId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExecutionId = executionId;
            LocationId = locationId;
            MetadataStoreId = metadataStoreId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExecutionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/executions/{execution}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        public ExecutionName(string projectId, string locationId, string metadataStoreId, string executionId) : this(ResourceNameType.ProjectLocationMetadataStoreExecution, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)))
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
        /// The <c>Execution</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExecutionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MetadataStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MetadataStoreId { get; }

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
                case ResourceNameType.ProjectLocationMetadataStoreExecution: return s_projectLocationMetadataStoreExecution.Expand(ProjectId, LocationId, MetadataStoreId, ExecutionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExecutionName);

        /// <inheritdoc/>
        public bool Equals(ExecutionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExecutionName a, ExecutionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExecutionName a, ExecutionName b) => !(a == b);
    }

    public partial class Execution
    {
        /// <summary>
        /// <see cref="gcav::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
