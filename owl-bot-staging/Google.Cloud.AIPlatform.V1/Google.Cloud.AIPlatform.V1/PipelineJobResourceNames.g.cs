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
    /// <summary>Resource name for the <c>PipelineJob</c> resource.</summary>
    public sealed partial class PipelineJobName : gax::IResourceName, sys::IEquatable<PipelineJobName>
    {
        /// <summary>The possible contents of <see cref="PipelineJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
            /// </summary>
            ProjectLocationPipelineJob = 1,
        }

        private static gax::PathTemplate s_projectLocationPipelineJob = new gax::PathTemplate("projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}");

        /// <summary>Creates a <see cref="PipelineJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PipelineJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PipelineJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PipelineJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PipelineJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineJobId">The <c>PipelineJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PipelineJobName"/> constructed from the provided ids.</returns>
        public static PipelineJobName FromProjectLocationPipelineJob(string projectId, string locationId, string pipelineJobId) =>
            new PipelineJobName(ResourceNameType.ProjectLocationPipelineJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pipelineJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineJobId, nameof(pipelineJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PipelineJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineJobId">The <c>PipelineJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PipelineJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string pipelineJobId) =>
            FormatProjectLocationPipelineJob(projectId, locationId, pipelineJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PipelineJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineJobId">The <c>PipelineJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PipelineJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>.
        /// </returns>
        public static string FormatProjectLocationPipelineJob(string projectId, string locationId, string pipelineJobId) =>
            s_projectLocationPipelineJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineJobId, nameof(pipelineJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="PipelineJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pipelineJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PipelineJobName"/> if successful.</returns>
        public static PipelineJobName Parse(string pipelineJobName) => Parse(pipelineJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PipelineJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pipelineJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PipelineJobName"/> if successful.</returns>
        public static PipelineJobName Parse(string pipelineJobName, bool allowUnparsed) =>
            TryParse(pipelineJobName, allowUnparsed, out PipelineJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PipelineJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pipelineJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PipelineJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pipelineJobName, out PipelineJobName result) =>
            TryParse(pipelineJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PipelineJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pipelineJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PipelineJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pipelineJobName, bool allowUnparsed, out PipelineJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(pipelineJobName, nameof(pipelineJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPipelineJob.TryParseName(pipelineJobName, out resourceName))
            {
                result = FromProjectLocationPipelineJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pipelineJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PipelineJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string pipelineJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PipelineJobId = pipelineJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PipelineJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/pipelineJobs/{pipeline_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pipelineJobId">The <c>PipelineJob</c> ID. Must not be <c>null</c> or empty.</param>
        public PipelineJobName(string projectId, string locationId, string pipelineJobId) : this(ResourceNameType.ProjectLocationPipelineJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), pipelineJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(pipelineJobId, nameof(pipelineJobId)))
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
        /// The <c>PipelineJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PipelineJobId { get; }

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
                case ResourceNameType.ProjectLocationPipelineJob: return s_projectLocationPipelineJob.Expand(ProjectId, LocationId, PipelineJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PipelineJobName);

        /// <inheritdoc/>
        public bool Equals(PipelineJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PipelineJobName a, PipelineJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PipelineJobName a, PipelineJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    public partial class PipelineJob
    {
        /// <summary>
        /// <see cref="gcav::PipelineJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PipelineJobName PipelineJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PipelineJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }

    public partial class PipelineTaskExecutorDetail
    {
        public partial class Types
        {
            public partial class ContainerDetail
            {
                /// <summary>
                /// <see cref="CustomJobName"/>-typed view over the <see cref="MainJob"/> resource name property.
                /// </summary>
                public CustomJobName MainJobAsCustomJobName
                {
                    get => string.IsNullOrEmpty(MainJob) ? null : CustomJobName.Parse(MainJob, allowUnparsed: true);
                    set => MainJob = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="CustomJobName"/>-typed view over the <see cref="PreCachingCheckJob"/> resource name
                /// property.
                /// </summary>
                public CustomJobName PreCachingCheckJobAsCustomJobName
                {
                    get => string.IsNullOrEmpty(PreCachingCheckJob) ? null : CustomJobName.Parse(PreCachingCheckJob, allowUnparsed: true);
                    set => PreCachingCheckJob = value?.ToString() ?? "";
                }
            }

            public partial class CustomJobDetail
            {
                /// <summary>
                /// <see cref="CustomJobName"/>-typed view over the <see cref="Job"/> resource name property.
                /// </summary>
                public CustomJobName JobAsCustomJobName
                {
                    get => string.IsNullOrEmpty(Job) ? null : CustomJobName.Parse(Job, allowUnparsed: true);
                    set => Job = value?.ToString() ?? "";
                }
            }
        }
    }
}
