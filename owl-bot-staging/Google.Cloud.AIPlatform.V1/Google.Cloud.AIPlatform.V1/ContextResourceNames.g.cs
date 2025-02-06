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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>Context</c> resource.</summary>
    public sealed partial class ContextName : gax::IResourceName, sys::IEquatable<ContextName>
    {
        /// <summary>The possible contents of <see cref="ContextName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
            /// </summary>
            ProjectLocationMetadataStoreContext = 1,
        }

        private static gax::PathTemplate s_projectLocationMetadataStoreContext = new gax::PathTemplate("projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}");

        /// <summary>Creates a <see cref="ContextName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContextName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContextName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContextName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContextName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContextName"/> constructed from the provided ids.</returns>
        public static ContextName FromProjectLocationMetadataStoreContext(string projectId, string locationId, string metadataStoreId, string contextId) =>
            new ContextName(ResourceNameType.ProjectLocationMetadataStoreContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string metadataStoreId, string contextId) =>
            FormatProjectLocationMetadataStoreContext(projectId, locationId, metadataStoreId, contextId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContextName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>.
        /// </returns>
        public static string FormatProjectLocationMetadataStoreContext(string projectId, string locationId, string metadataStoreId, string contextId) =>
            s_projectLocationMetadataStoreContext.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContextName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContextName"/> if successful.</returns>
        public static ContextName Parse(string contextName) => Parse(contextName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContextName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContextName"/> if successful.</returns>
        public static ContextName Parse(string contextName, bool allowUnparsed) =>
            TryParse(contextName, allowUnparsed, out ContextName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContextName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContextName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contextName, out ContextName result) => TryParse(contextName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContextName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contextName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContextName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contextName, bool allowUnparsed, out ContextName result)
        {
            gax::GaxPreconditions.CheckNotNull(contextName, nameof(contextName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMetadataStoreContext.TryParseName(contextName, out resourceName))
            {
                result = FromProjectLocationMetadataStoreContext(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contextName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContextName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contextId = null, string locationId = null, string metadataStoreId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContextId = contextId;
            LocationId = locationId;
            MetadataStoreId = metadataStoreId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContextName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/contexts/{context}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contextId">The <c>Context</c> ID. Must not be <c>null</c> or empty.</param>
        public ContextName(string projectId, string locationId, string metadataStoreId, string contextId) : this(ResourceNameType.ProjectLocationMetadataStoreContext, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), contextId: gax::GaxPreconditions.CheckNotNullOrEmpty(contextId, nameof(contextId)))
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
        /// The <c>Context</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ContextId { get; }

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
                case ResourceNameType.ProjectLocationMetadataStoreContext: return s_projectLocationMetadataStoreContext.Expand(ProjectId, LocationId, MetadataStoreId, ContextId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContextName);

        /// <inheritdoc/>
        public bool Equals(ContextName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContextName a, ContextName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContextName a, ContextName b) => !(a == b);
    }

    public partial class Context
    {
        /// <summary>
        /// <see cref="gcav::ContextName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ContextName ContextName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ContextName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcav::ContextName"/>-typed view over the <see cref="ParentContexts"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gcav::ContextName> ParentContextsAsContextNames
        {
            get => new gax::ResourceNameList<gcav::ContextName>(ParentContexts, s => string.IsNullOrEmpty(s) ? null : gcav::ContextName.Parse(s, allowUnparsed: true));
        }
    }
}
