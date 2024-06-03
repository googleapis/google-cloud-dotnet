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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdlv = Google.Cloud.DataCatalog.Lineage.V1;
using sys = System;

namespace Google.Cloud.DataCatalog.Lineage.V1
{
    /// <summary>Resource name for the <c>Process</c> resource.</summary>
    public sealed partial class ProcessName : gax::IResourceName, sys::IEquatable<ProcessName>
    {
        /// <summary>The possible contents of <see cref="ProcessName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processes/{process}</c>.
            /// </summary>
            ProjectLocationProcess = 1,
        }

        private static gax::PathTemplate s_projectLocationProcess = new gax::PathTemplate("projects/{project}/locations/{location}/processes/{process}");

        /// <summary>Creates a <see cref="ProcessName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessName"/> constructed from the provided ids.</returns>
        public static ProcessName FromProjectLocationProcess(string projectId, string locationId, string processId) =>
            new ProcessName(ResourceNameType.ProjectLocationProcess, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processId) =>
            FormatProjectLocationProcess(projectId, locationId, processId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>.
        /// </returns>
        public static string FormatProjectLocationProcess(string projectId, string locationId, string processId) =>
            s_projectLocationProcess.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProcessName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/processes/{process}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessName"/> if successful.</returns>
        public static ProcessName Parse(string processName) => Parse(processName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/processes/{process}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessName"/> if successful.</returns>
        public static ProcessName Parse(string processName, bool allowUnparsed) =>
            TryParse(processName, allowUnparsed, out ProcessName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/processes/{process}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processName, out ProcessName result) => TryParse(processName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/processes/{process}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processName, bool allowUnparsed, out ProcessName result)
        {
            gax::GaxPreconditions.CheckNotNull(processName, nameof(processName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcess.TryParseName(processName, out resourceName))
            {
                result = FromProjectLocationProcess(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessId = processId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessName(string projectId, string locationId, string processId) : this(ResourceNameType.ProjectLocationProcess, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)))
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
        /// The <c>Process</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessId { get; }

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
                case ResourceNameType.ProjectLocationProcess: return s_projectLocationProcess.Expand(ProjectId, LocationId, ProcessId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessName);

        /// <inheritdoc/>
        public bool Equals(ProcessName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProcessName a, ProcessName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProcessName a, ProcessName b) => !(a == b);
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
            /// A resource name with pattern <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>
            /// .
            /// </summary>
            ProjectLocationProcessRun = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessRun = new gax::PathTemplate("projects/{project}/locations/{location}/processes/{process}/runs/{run}");

        /// <summary>Creates a <see cref="RunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RunName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RunName"/> constructed from the provided ids.</returns>
        public static RunName FromProjectLocationProcessRun(string projectId, string locationId, string processId, string runId) =>
            new RunName(ResourceNameType.ProjectLocationProcessRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processId, string runId) =>
            FormatProjectLocationProcessRun(projectId, locationId, processId, runId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessRun(string projectId, string locationId, string processId, string runId) =>
            s_projectLocationProcessRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)));

        /// <summary>Parses the given resource name string into a new <see cref="RunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c></description>
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
            if (s_projectLocationProcessRun.TryParseName(runName, out resourceName))
            {
                result = FromProjectLocationProcessRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private RunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processId = null, string projectId = null, string runId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessId = processId;
            ProjectId = projectId;
            RunId = runId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RunName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        public RunName(string projectId, string locationId, string processId, string runId) : this(ResourceNameType.ProjectLocationProcessRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)))
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
        /// The <c>Process</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Run</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RunId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProcessRun: return s_projectLocationProcessRun.Expand(ProjectId, LocationId, ProcessId, RunId);
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

    /// <summary>Resource name for the <c>LineageEvent</c> resource.</summary>
    public sealed partial class LineageEventName : gax::IResourceName, sys::IEquatable<LineageEventName>
    {
        /// <summary>The possible contents of <see cref="LineageEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
            /// .
            /// </summary>
            ProjectLocationProcessRunLineageEvent = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessRunLineageEvent = new gax::PathTemplate("projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}");

        /// <summary>Creates a <see cref="LineageEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LineageEventName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LineageEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LineageEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LineageEventName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineageEventId">The <c>LineageEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LineageEventName"/> constructed from the provided ids.</returns>
        public static LineageEventName FromProjectLocationProcessRunLineageEvent(string projectId, string locationId, string processId, string runId, string lineageEventId) =>
            new LineageEventName(ResourceNameType.ProjectLocationProcessRunLineageEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)), lineageEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(lineageEventId, nameof(lineageEventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LineageEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineageEventId">The <c>LineageEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LineageEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processId, string runId, string lineageEventId) =>
            FormatProjectLocationProcessRunLineageEvent(projectId, locationId, processId, runId, lineageEventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LineageEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineageEventId">The <c>LineageEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LineageEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>.
        /// </returns>
        public static string FormatProjectLocationProcessRunLineageEvent(string projectId, string locationId, string processId, string runId, string lineageEventId) =>
            s_projectLocationProcessRunLineageEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lineageEventId, nameof(lineageEventId)));

        /// <summary>Parses the given resource name string into a new <see cref="LineageEventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lineageEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LineageEventName"/> if successful.</returns>
        public static LineageEventName Parse(string lineageEventName) => Parse(lineageEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LineageEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lineageEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LineageEventName"/> if successful.</returns>
        public static LineageEventName Parse(string lineageEventName, bool allowUnparsed) =>
            TryParse(lineageEventName, allowUnparsed, out LineageEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LineageEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="lineageEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LineageEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lineageEventName, out LineageEventName result) =>
            TryParse(lineageEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LineageEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lineageEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LineageEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lineageEventName, bool allowUnparsed, out LineageEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(lineageEventName, nameof(lineageEventName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessRunLineageEvent.TryParseName(lineageEventName, out resourceName))
            {
                result = FromProjectLocationProcessRunLineageEvent(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lineageEventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LineageEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string lineageEventId = null, string locationId = null, string processId = null, string projectId = null, string runId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LineageEventId = lineageEventId;
            LocationId = locationId;
            ProcessId = processId;
            ProjectId = projectId;
            RunId = runId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LineageEventName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processes/{process}/runs/{run}/lineageEvents/{lineage_event}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runId">The <c>Run</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lineageEventId">The <c>LineageEvent</c> ID. Must not be <c>null</c> or empty.</param>
        public LineageEventName(string projectId, string locationId, string processId, string runId, string lineageEventId) : this(ResourceNameType.ProjectLocationProcessRunLineageEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)), runId: gax::GaxPreconditions.CheckNotNullOrEmpty(runId, nameof(runId)), lineageEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(lineageEventId, nameof(lineageEventId)))
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
        /// The <c>LineageEvent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LineageEventId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Process</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Run</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RunId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationProcessRunLineageEvent: return s_projectLocationProcessRunLineageEvent.Expand(ProjectId, LocationId, ProcessId, RunId, LineageEventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LineageEventName);

        /// <inheritdoc/>
        public bool Equals(LineageEventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LineageEventName a, LineageEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LineageEventName a, LineageEventName b) => !(a == b);
    }

    public partial class Process
    {
        /// <summary>
        /// <see cref="gcdlv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Run
    {
        /// <summary>
        /// <see cref="gcdlv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LineageEvent
    {
        /// <summary>
        /// <see cref="gcdlv::LineageEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::LineageEventName LineageEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::LineageEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProcessOpenLineageRunEventResponse
    {
        /// <summary>
        /// <see cref="ProcessName"/>-typed view over the <see cref="Process"/> resource name property.
        /// </summary>
        public ProcessName ProcessAsProcessName
        {
            get => string.IsNullOrEmpty(Process) ? null : ProcessName.Parse(Process, allowUnparsed: true);
            set => Process = value?.ToString() ?? "";
        }

        /// <summary><see cref="RunName"/>-typed view over the <see cref="Run"/> resource name property.</summary>
        public RunName RunAsRunName
        {
            get => string.IsNullOrEmpty(Run) ? null : RunName.Parse(Run, allowUnparsed: true);
            set => Run = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LineageEventName"/>-typed view over the <see cref="LineageEvents"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<LineageEventName> LineageEventsAsLineageEventNames
        {
            get => new gax::ResourceNameList<LineageEventName>(LineageEvents, s => string.IsNullOrEmpty(s) ? null : LineageEventName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreateProcessRequest
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

    public partial class GetProcessRequest
    {
        /// <summary>
        /// <see cref="gcdlv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessesRequest
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

    public partial class DeleteProcessRequest
    {
        /// <summary>
        /// <see cref="gcdlv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRunRequest
    {
        /// <summary>
        /// <see cref="ProcessName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProcessName ParentAsProcessName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProcessName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRunRequest
    {
        /// <summary>
        /// <see cref="gcdlv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRunsRequest
    {
        /// <summary>
        /// <see cref="ProcessName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProcessName ParentAsProcessName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProcessName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteRunRequest
    {
        /// <summary>
        /// <see cref="gcdlv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLineageEventRequest
    {
        /// <summary><see cref="RunName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RunName ParentAsRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLineageEventRequest
    {
        /// <summary>
        /// <see cref="gcdlv::LineageEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::LineageEventName LineageEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::LineageEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLineageEventsRequest
    {
        /// <summary><see cref="RunName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RunName ParentAsRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLineageEventRequest
    {
        /// <summary>
        /// <see cref="gcdlv::LineageEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdlv::LineageEventName LineageEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdlv::LineageEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchLinksRequest
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

    public partial class BatchSearchLinkProcessesRequest
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

    public partial class ProcessLinks
    {
        /// <summary>
        /// <see cref="ProcessName"/>-typed view over the <see cref="Process"/> resource name property.
        /// </summary>
        public ProcessName ProcessAsProcessName
        {
            get => string.IsNullOrEmpty(Process) ? null : ProcessName.Parse(Process, allowUnparsed: true);
            set => Process = value?.ToString() ?? "";
        }
    }
}
