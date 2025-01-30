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
using gcdv = Google.Cloud.DocumentAI.V1Beta3;
using sys = System;

namespace Google.Cloud.DocumentAI.V1Beta3
{
    /// <summary>Resource name for the <c>ProcessorVersion</c> resource.</summary>
    public sealed partial class ProcessorVersionName : gax::IResourceName, sys::IEquatable<ProcessorVersionName>
    {
        /// <summary>The possible contents of <see cref="ProcessorVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
            /// .
            /// </summary>
            ProjectLocationProcessorProcessorVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessorProcessorVersion = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}");

        /// <summary>Creates a <see cref="ProcessorVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessorVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessorVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessorVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessorVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorVersionId">The <c>ProcessorVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessorVersionName"/> constructed from the provided ids.</returns>
        public static ProcessorVersionName FromProjectLocationProcessorProcessorVersion(string projectId, string locationId, string processorId, string processorVersionId) =>
            new ProcessorVersionName(ResourceNameType.ProjectLocationProcessorProcessorVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)), processorVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorVersionId, nameof(processorVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorVersionId">The <c>ProcessorVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId, string processorVersionId) =>
            FormatProjectLocationProcessorProcessorVersion(projectId, locationId, processorId, processorVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorVersionId">The <c>ProcessorVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessorProcessorVersion(string projectId, string locationId, string processorId, string processorVersionId) =>
            s_projectLocationProcessorProcessorVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorVersionId, nameof(processorVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessorVersionName"/> if successful.</returns>
        public static ProcessorVersionName Parse(string processorVersionName) => Parse(processorVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessorVersionName"/> if successful.</returns>
        public static ProcessorVersionName Parse(string processorVersionName, bool allowUnparsed) =>
            TryParse(processorVersionName, allowUnparsed, out ProcessorVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorVersionName, out ProcessorVersionName result) =>
            TryParse(processorVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorVersionName, bool allowUnparsed, out ProcessorVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(processorVersionName, nameof(processorVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessorProcessorVersion.TryParseName(processorVersionName, out resourceName))
            {
                result = FromProjectLocationProcessorProcessorVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processorVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessorVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string processorVersionId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProcessorVersionId = processorVersionId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessorVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processor_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorVersionId">The <c>ProcessorVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessorVersionName(string projectId, string locationId, string processorId, string processorVersionId) : this(ResourceNameType.ProjectLocationProcessorProcessorVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)), processorVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorVersionId, nameof(processorVersionId)))
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
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

        /// <summary>
        /// The <c>ProcessorVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ProcessorVersionId { get; }

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
                case ResourceNameType.ProjectLocationProcessorProcessorVersion: return s_projectLocationProcessorProcessorVersion.Expand(ProjectId, LocationId, ProcessorId, ProcessorVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessorVersionName);

        /// <inheritdoc/>
        public bool Equals(ProcessorVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProcessorVersionName a, ProcessorVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProcessorVersionName a, ProcessorVersionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Processor</c> resource.</summary>
    public sealed partial class ProcessorName : gax::IResourceName, sys::IEquatable<ProcessorName>
    {
        /// <summary>The possible contents of <see cref="ProcessorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processors/{processor}</c>.
            /// </summary>
            ProjectLocationProcessor = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessor = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}");

        /// <summary>Creates a <see cref="ProcessorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessorName"/> constructed from the provided ids.</returns>
        public static ProcessorName FromProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            new ProcessorName(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId) =>
            FormatProjectLocationProcessor(projectId, locationId, processorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            s_projectLocationProcessor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProcessorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessorName"/> if successful.</returns>
        public static ProcessorName Parse(string processorName) => Parse(processorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessorName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessorName"/> if successful.</returns>
        public static ProcessorName Parse(string processorName, bool allowUnparsed) =>
            TryParse(processorName, allowUnparsed, out ProcessorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorName, out ProcessorName result) => TryParse(processorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processors/{processor}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processorName, bool allowUnparsed, out ProcessorName result)
        {
            gax::GaxPreconditions.CheckNotNull(processorName, nameof(processorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessor.TryParseName(processorName, out resourceName))
            {
                result = FromProjectLocationProcessor(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessorName(string projectId, string locationId, string processorId) : this(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)))
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
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

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
                case ResourceNameType.ProjectLocationProcessor: return s_projectLocationProcessor.Expand(ProjectId, LocationId, ProcessorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessorName);

        /// <inheritdoc/>
        public bool Equals(ProcessorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProcessorName a, ProcessorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProcessorName a, ProcessorName b) => !(a == b);
    }

    public partial class ProcessorVersion
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorVersionName ProcessorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class DeprecationInfo
            {
                /// <summary>
                /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the
                /// <see cref="ReplacementProcessorVersion"/> resource name property.
                /// </summary>
                public gcdv::ProcessorVersionName ReplacementProcessorVersionAsProcessorVersionName
                {
                    get => string.IsNullOrEmpty(ReplacementProcessorVersion) ? null : gcdv::ProcessorVersionName.Parse(ReplacementProcessorVersion, allowUnparsed: true);
                    set => ReplacementProcessorVersion = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ProcessorVersionAlias
    {
        /// <summary>
        /// <see cref="ProcessorVersionName"/>-typed view over the <see cref="ProcessorVersion"/> resource name
        /// property.
        /// </summary>
        public ProcessorVersionName ProcessorVersionAsProcessorVersionName
        {
            get => string.IsNullOrEmpty(ProcessorVersion) ? null : ProcessorVersionName.Parse(ProcessorVersion, allowUnparsed: true);
            set => ProcessorVersion = value?.ToString() ?? "";
        }
    }

    public partial class Processor
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProcessorVersionName"/>-typed view over the <see cref="DefaultProcessorVersion"/> resource name
        /// property.
        /// </summary>
        public ProcessorVersionName DefaultProcessorVersionAsProcessorVersionName
        {
            get => string.IsNullOrEmpty(DefaultProcessorVersion) ? null : ProcessorVersionName.Parse(DefaultProcessorVersion, allowUnparsed: true);
            set => DefaultProcessorVersion = value?.ToString() ?? "";
        }
    }
}
