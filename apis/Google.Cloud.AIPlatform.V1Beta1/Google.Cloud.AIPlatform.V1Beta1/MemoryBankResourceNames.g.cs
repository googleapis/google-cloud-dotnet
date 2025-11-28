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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Memory</c> resource.</summary>
    public sealed partial class MemoryName : gax::IResourceName, sys::IEquatable<MemoryName>
    {
        /// <summary>The possible contents of <see cref="MemoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
            /// </summary>
            ProjectLocationReasoningEngineMemory = 1,
        }

        private static gax::PathTemplate s_projectLocationReasoningEngineMemory = new gax::PathTemplate("projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}");

        /// <summary>Creates a <see cref="MemoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MemoryName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MemoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MemoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MemoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="memoryId">The <c>Memory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MemoryName"/> constructed from the provided ids.</returns>
        public static MemoryName FromProjectLocationReasoningEngineMemory(string projectId, string locationId, string reasoningEngineId, string memoryId) =>
            new MemoryName(ResourceNameType.ProjectLocationReasoningEngineMemory, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), memoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(memoryId, nameof(memoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MemoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="memoryId">The <c>Memory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MemoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reasoningEngineId, string memoryId) =>
            FormatProjectLocationReasoningEngineMemory(projectId, locationId, reasoningEngineId, memoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MemoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="memoryId">The <c>Memory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MemoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>.
        /// </returns>
        public static string FormatProjectLocationReasoningEngineMemory(string projectId, string locationId, string reasoningEngineId, string memoryId) =>
            s_projectLocationReasoningEngineMemory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(memoryId, nameof(memoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="MemoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="memoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MemoryName"/> if successful.</returns>
        public static MemoryName Parse(string memoryName) => Parse(memoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MemoryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="memoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MemoryName"/> if successful.</returns>
        public static MemoryName Parse(string memoryName, bool allowUnparsed) =>
            TryParse(memoryName, allowUnparsed, out MemoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MemoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="memoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MemoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string memoryName, out MemoryName result) => TryParse(memoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MemoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="memoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MemoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string memoryName, bool allowUnparsed, out MemoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(memoryName, nameof(memoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReasoningEngineMemory.TryParseName(memoryName, out resourceName))
            {
                result = FromProjectLocationReasoningEngineMemory(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(memoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MemoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string memoryId = null, string projectId = null, string reasoningEngineId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MemoryId = memoryId;
            ProjectId = projectId;
            ReasoningEngineId = reasoningEngineId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MemoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/memories/{memory}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="memoryId">The <c>Memory</c> ID. Must not be <c>null</c> or empty.</param>
        public MemoryName(string projectId, string locationId, string reasoningEngineId, string memoryId) : this(ResourceNameType.ProjectLocationReasoningEngineMemory, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), memoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(memoryId, nameof(memoryId)))
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
        /// The <c>Memory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MemoryId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReasoningEngine</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReasoningEngineId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReasoningEngineMemory: return s_projectLocationReasoningEngineMemory.Expand(ProjectId, LocationId, ReasoningEngineId, MemoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MemoryName);

        /// <inheritdoc/>
        public bool Equals(MemoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MemoryName a, MemoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MemoryName a, MemoryName b) => !(a == b);
    }

    public partial class Memory
    {
        /// <summary>
        /// <see cref="gcav::MemoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MemoryName MemoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MemoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
