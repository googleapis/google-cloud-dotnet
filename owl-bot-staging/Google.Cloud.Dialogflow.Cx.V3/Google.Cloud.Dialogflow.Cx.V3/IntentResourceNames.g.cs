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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Intent</c> resource.</summary>
    public sealed partial class IntentName : gax::IResourceName, sys::IEquatable<IntentName>
    {
        /// <summary>The possible contents of <see cref="IntentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>
            /// .
            /// </summary>
            ProjectLocationAgentIntent = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentIntent = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/intents/{intent}");

        /// <summary>Creates a <see cref="IntentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IntentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IntentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IntentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IntentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="intentId">The <c>Intent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IntentName"/> constructed from the provided ids.</returns>
        public static IntentName FromProjectLocationAgentIntent(string projectId, string locationId, string agentId, string intentId) =>
            new IntentName(ResourceNameType.ProjectLocationAgentIntent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), intentId: gax::GaxPreconditions.CheckNotNullOrEmpty(intentId, nameof(intentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="intentId">The <c>Intent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string intentId) =>
            FormatProjectLocationAgentIntent(projectId, locationId, agentId, intentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IntentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="intentId">The <c>Intent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IntentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentIntent(string projectId, string locationId, string agentId, string intentId) =>
            s_projectLocationAgentIntent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(intentId, nameof(intentId)));

        /// <summary>Parses the given resource name string into a new <see cref="IntentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="intentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IntentName"/> if successful.</returns>
        public static IntentName Parse(string intentName) => Parse(intentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IntentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="intentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IntentName"/> if successful.</returns>
        public static IntentName Parse(string intentName, bool allowUnparsed) =>
            TryParse(intentName, allowUnparsed, out IntentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IntentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="intentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IntentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string intentName, out IntentName result) => TryParse(intentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IntentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="intentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IntentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string intentName, bool allowUnparsed, out IntentName result)
        {
            gax::GaxPreconditions.CheckNotNull(intentName, nameof(intentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentIntent.TryParseName(intentName, out resourceName))
            {
                result = FromProjectLocationAgentIntent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(intentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IntentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string intentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            IntentId = intentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IntentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/intents/{intent}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="intentId">The <c>Intent</c> ID. Must not be <c>null</c> or empty.</param>
        public IntentName(string projectId, string locationId, string agentId, string intentId) : this(ResourceNameType.ProjectLocationAgentIntent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), intentId: gax::GaxPreconditions.CheckNotNullOrEmpty(intentId, nameof(intentId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Intent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IntentId { get; }

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
                case ResourceNameType.ProjectLocationAgentIntent: return s_projectLocationAgentIntent.Expand(ProjectId, LocationId, AgentId, IntentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IntentName);

        /// <inheritdoc/>
        public bool Equals(IntentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IntentName a, IntentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IntentName a, IntentName b) => !(a == b);
    }

    public partial class Intent
    {
        /// <summary>
        /// <see cref="gcdcv::IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::IntentName IntentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::IntentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Parameter
            {
                /// <summary>
                /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
                /// </summary>
                public EntityTypeName EntityTypeAsEntityTypeName
                {
                    get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
                    set => EntityType = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListIntentsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIntentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::IntentName IntentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::IntentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateIntentRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIntentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::IntentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::IntentName IntentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::IntentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportIntentsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportIntentsResponse
    {
        /// <summary>
        /// <see cref="IntentName"/>-typed view over the <see cref="Intents"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<IntentName> IntentsAsIntentNames
        {
            get => new gax::ResourceNameList<IntentName>(Intents, s => string.IsNullOrEmpty(s) ? null : IntentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ExportIntentsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
