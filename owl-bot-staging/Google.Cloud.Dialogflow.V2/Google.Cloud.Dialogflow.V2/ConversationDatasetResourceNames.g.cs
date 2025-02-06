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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>ConversationDataset</c> resource.</summary>
    public sealed partial class ConversationDatasetName : gax::IResourceName, sys::IEquatable<ConversationDatasetName>
    {
        /// <summary>The possible contents of <see cref="ConversationDatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
            /// </summary>
            ProjectLocationConversationDataset = 1,
        }

        private static gax::PathTemplate s_projectLocationConversationDataset = new gax::PathTemplate("projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}");

        /// <summary>Creates a <see cref="ConversationDatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversationDatasetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversationDatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversationDatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversationDatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationDatasetId">
        /// The <c>ConversationDataset</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversationDatasetName"/> constructed from the provided ids.
        /// </returns>
        public static ConversationDatasetName FromProjectLocationConversationDataset(string projectId, string locationId, string conversationDatasetId) =>
            new ConversationDatasetName(ResourceNameType.ProjectLocationConversationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationDatasetId, nameof(conversationDatasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationDatasetId">
        /// The <c>ConversationDataset</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string conversationDatasetId) =>
            FormatProjectLocationConversationDataset(projectId, locationId, conversationDatasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationDatasetId">
        /// The <c>ConversationDataset</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>.
        /// </returns>
        public static string FormatProjectLocationConversationDataset(string projectId, string locationId, string conversationDatasetId) =>
            s_projectLocationConversationDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversationDatasetId, nameof(conversationDatasetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversationDatasetName"/> if successful.</returns>
        public static ConversationDatasetName Parse(string conversationDatasetName) => Parse(conversationDatasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversationDatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversationDatasetName"/> if successful.</returns>
        public static ConversationDatasetName Parse(string conversationDatasetName, bool allowUnparsed) =>
            TryParse(conversationDatasetName, allowUnparsed, out ConversationDatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationDatasetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationDatasetName, out ConversationDatasetName result) =>
            TryParse(conversationDatasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversationDatasetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversationDatasetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversationDatasetName, bool allowUnparsed, out ConversationDatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversationDatasetName, nameof(conversationDatasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConversationDataset.TryParseName(conversationDatasetName, out resourceName))
            {
                result = FromProjectLocationConversationDataset(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversationDatasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversationDatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversationDatasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversationDatasetId = conversationDatasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversationDatasetName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/conversationDatasets/{conversation_dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversationDatasetId">
        /// The <c>ConversationDataset</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversationDatasetName(string projectId, string locationId, string conversationDatasetId) : this(ResourceNameType.ProjectLocationConversationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), conversationDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversationDatasetId, nameof(conversationDatasetId)))
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
        /// The <c>ConversationDataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ConversationDatasetId { get; }

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
                case ResourceNameType.ProjectLocationConversationDataset: return s_projectLocationConversationDataset.Expand(ProjectId, LocationId, ConversationDatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversationDatasetName);

        /// <inheritdoc/>
        public bool Equals(ConversationDatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversationDatasetName a, ConversationDatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversationDatasetName a, ConversationDatasetName b) => !(a == b);
    }

    public partial class ConversationDataset
    {
        /// <summary>
        /// <see cref="gcdv::ConversationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationDatasetName ConversationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetConversationDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationDatasetName ConversationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConversationDatasetsRequest
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

    public partial class DeleteConversationDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationDatasetName ConversationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportConversationDataRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationDatasetName ConversationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportConversationDataOperationMetadata
    {
        /// <summary>
        /// <see cref="ConversationDatasetName"/>-typed view over the <see cref="ConversationDataset"/> resource name
        /// property.
        /// </summary>
        public ConversationDatasetName ConversationDatasetAsConversationDatasetName
        {
            get => string.IsNullOrEmpty(ConversationDataset) ? null : ConversationDatasetName.Parse(ConversationDataset, allowUnparsed: true);
            set => ConversationDataset = value?.ToString() ?? "";
        }
    }

    public partial class ImportConversationDataOperationResponse
    {
        /// <summary>
        /// <see cref="ConversationDatasetName"/>-typed view over the <see cref="ConversationDataset"/> resource name
        /// property.
        /// </summary>
        public ConversationDatasetName ConversationDatasetAsConversationDatasetName
        {
            get => string.IsNullOrEmpty(ConversationDataset) ? null : ConversationDatasetName.Parse(ConversationDataset, allowUnparsed: true);
            set => ConversationDataset = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversationDatasetOperationMetadata
    {
        /// <summary>
        /// <see cref="ConversationDatasetName"/>-typed view over the <see cref="ConversationDataset"/> resource name
        /// property.
        /// </summary>
        public ConversationDatasetName ConversationDatasetAsConversationDatasetName
        {
            get => string.IsNullOrEmpty(ConversationDataset) ? null : ConversationDatasetName.Parse(ConversationDataset, allowUnparsed: true);
            set => ConversationDataset = value?.ToString() ?? "";
        }
    }
}
