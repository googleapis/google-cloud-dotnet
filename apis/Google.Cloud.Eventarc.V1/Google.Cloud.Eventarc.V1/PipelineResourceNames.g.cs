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
using gcev = Google.Cloud.Eventarc.V1;
using sys = System;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Resource name for the <c>Pipeline</c> resource.</summary>
    public sealed partial class PipelineName : gax::IResourceName, sys::IEquatable<PipelineName>
    {
        /// <summary>The possible contents of <see cref="PipelineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
            /// </summary>
            ProjectLocationPipeline = 1,
        }

        private static gax::PathTemplate s_projectLocationPipeline = new gax::PathTemplate("projects/{project}/locations/{location}/pipelines/{pipeline}");

        /// <summary>Creates a <see cref="PipelineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PipelineName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static PipelineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PipelineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PipelineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineId">The <c>Pipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PipelineName"/> constructed from the provided ids.</returns>
        public static PipelineName FromProjectLocationPipeline(string projectId, string locationId, string pipelineId) =>
            new PipelineName(ResourceNameType.ProjectLocationPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineId">The <c>Pipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string pipelineId) =>
            FormatProjectLocationPipeline(projectId, locationId, pipelineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineId">The <c>Pipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>.
        /// </returns>
        public static string FormatProjectLocationPipeline(string projectId, string locationId, string pipelineId) =>
            s_projectLocationPipeline.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)));

        /// <summary>Parses the given resource name string into a new <see cref="PipelineName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pipelines/{pipeline}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PipelineName"/> if successful.</returns>
        public static PipelineName Parse(string pipelineName) => Parse(pipelineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PipelineName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pipelines/{pipeline}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PipelineName"/> if successful.</returns>
        public static PipelineName Parse(string pipelineName, bool allowUnparsed) =>
            TryParse(pipelineName, allowUnparsed, out PipelineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PipelineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pipelines/{pipeline}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="pipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pipelineName, out PipelineName result) => TryParse(pipelineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PipelineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/pipelines/{pipeline}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pipelineName, bool allowUnparsed, out PipelineName result)
        {
            gax::GaxPreconditions.CheckNotNull(pipelineName, nameof(pipelineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPipeline.TryParseName(pipelineName, out resourceName))
            {
                result = FromProjectLocationPipeline(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pipelineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PipelineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string pipelineId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PipelineId = pipelineId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PipelineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/pipelines/{pipeline}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineId">The <c>Pipeline</c> ID. Must not be <c>null</c> or empty.</param>
        public PipelineName(string projectId, string locationId, string pipelineId) : this(ResourceNameType.ProjectLocationPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineId, nameof(pipelineId)))
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
        /// The <c>Pipeline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PipelineId { get; }

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
                case ResourceNameType.ProjectLocationPipeline: return s_projectLocationPipeline.Expand(ProjectId, LocationId, PipelineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PipelineName);

        /// <inheritdoc/>
        public bool Equals(PipelineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PipelineName a, PipelineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PipelineName a, PipelineName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Topic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    public partial class Pipeline
    {
        /// <summary>
        /// <see cref="gcev::PipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcev::PipelineName PipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcev::PipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcev::CryptoKeyName"/>-typed view over the <see cref="CryptoKeyName"/> resource name property.
        /// </summary>
        public gcev::CryptoKeyName CryptoKeyNameAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(CryptoKeyName) ? null : gcev::CryptoKeyName.Parse(CryptoKeyName, allowUnparsed: true);
            set => CryptoKeyName = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Destination
            {
                /// <summary>
                /// <see cref="WorkflowName"/>-typed view over the <see cref="Workflow"/> resource name property.
                /// </summary>
                public WorkflowName WorkflowAsWorkflowName
                {
                    get => string.IsNullOrEmpty(Workflow) ? null : WorkflowName.Parse(Workflow, allowUnparsed: true);
                    set => Workflow = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="MessageBusName"/>-typed view over the <see cref="MessageBus"/> resource name property.
                /// </summary>
                public MessageBusName MessageBusAsMessageBusName
                {
                    get => string.IsNullOrEmpty(MessageBus) ? null : MessageBusName.Parse(MessageBus, allowUnparsed: true);
                    set => MessageBus = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.
                /// </summary>
                public TopicName TopicAsTopicName
                {
                    get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
                    set => Topic = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class NetworkConfig
                    {
                        /// <summary>
                        /// <see cref="NetworkAttachmentName"/>-typed view over the <see cref="NetworkAttachment"/>
                        /// resource name property.
                        /// </summary>
                        public NetworkAttachmentName NetworkAttachmentAsNetworkAttachmentName
                        {
                            get => string.IsNullOrEmpty(NetworkAttachment) ? null : NetworkAttachmentName.Parse(NetworkAttachment, allowUnparsed: true);
                            set => NetworkAttachment = value?.ToString() ?? "";
                        }
                    }

                    public partial class AuthenticationConfig
                    {
                        public partial class Types
                        {
                            public partial class OidcToken
                            {
                                /// <summary>
                                /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/>
                                /// resource name property.
                                /// </summary>
                                public ServiceAccountName ServiceAccountAsServiceAccountName
                                {
                                    get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
                                    set => ServiceAccount = value?.ToString() ?? "";
                                }
                            }

                            public partial class OAuthToken
                            {
                                /// <summary>
                                /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/>
                                /// resource name property.
                                /// </summary>
                                public ServiceAccountName ServiceAccountAsServiceAccountName
                                {
                                    get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
                                    set => ServiceAccount = value?.ToString() ?? "";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
