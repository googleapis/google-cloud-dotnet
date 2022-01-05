// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcdv = Google.Cloud.Deploy.V1;
using sys = System;

namespace Google.Cloud.Deploy.V1
{
    /// <summary>Resource name for the <c>DeliveryPipeline</c> resource.</summary>
    public sealed partial class DeliveryPipelineName : gax::IResourceName, sys::IEquatable<DeliveryPipelineName>
    {
        /// <summary>The possible contents of <see cref="DeliveryPipelineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
            /// </summary>
            ProjectLocationDeliveryPipeline = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipeline = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}");

        /// <summary>Creates a <see cref="DeliveryPipelineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeliveryPipelineName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeliveryPipelineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeliveryPipelineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeliveryPipelineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeliveryPipelineName"/> constructed from the provided ids.</returns>
        public static DeliveryPipelineName FromProjectLocationDeliveryPipeline(string projectId, string locationId, string deliveryPipelineId) =>
            new DeliveryPipelineName(ResourceNameType.ProjectLocationDeliveryPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeliveryPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeliveryPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId) =>
            FormatProjectLocationDeliveryPipeline(projectId, locationId, deliveryPipelineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeliveryPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeliveryPipelineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>.
        /// </returns>
        public static string FormatProjectLocationDeliveryPipeline(string projectId, string locationId, string deliveryPipelineId) =>
            s_projectLocationDeliveryPipeline.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeliveryPipelineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deliveryPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeliveryPipelineName"/> if successful.</returns>
        public static DeliveryPipelineName Parse(string deliveryPipelineName) => Parse(deliveryPipelineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeliveryPipelineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deliveryPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeliveryPipelineName"/> if successful.</returns>
        public static DeliveryPipelineName Parse(string deliveryPipelineName, bool allowUnparsed) =>
            TryParse(deliveryPipelineName, allowUnparsed, out DeliveryPipelineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeliveryPipelineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deliveryPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeliveryPipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deliveryPipelineName, out DeliveryPipelineName result) =>
            TryParse(deliveryPipelineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeliveryPipelineName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deliveryPipelineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeliveryPipelineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deliveryPipelineName, bool allowUnparsed, out DeliveryPipelineName result)
        {
            gax::GaxPreconditions.CheckNotNull(deliveryPipelineName, nameof(deliveryPipelineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipeline.TryParseName(deliveryPipelineName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipeline(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deliveryPipelineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeliveryPipelineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deliveryPipelineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeliveryPipelineId = deliveryPipelineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeliveryPipelineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        public DeliveryPipelineName(string projectId, string locationId, string deliveryPipelineId) : this(ResourceNameType.ProjectLocationDeliveryPipeline, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)))
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
        /// The <c>DeliveryPipeline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DeliveryPipelineId { get; }

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
                case ResourceNameType.ProjectLocationDeliveryPipeline: return s_projectLocationDeliveryPipeline.Expand(ProjectId, LocationId, DeliveryPipelineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeliveryPipelineName);

        /// <inheritdoc/>
        public bool Equals(DeliveryPipelineName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DeliveryPipelineName a, DeliveryPipelineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DeliveryPipelineName a, DeliveryPipelineName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Target</c> resource.</summary>
    public sealed partial class TargetName : gax::IResourceName, sys::IEquatable<TargetName>
    {
        /// <summary>The possible contents of <see cref="TargetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/targets/{target}</c>.
            /// </summary>
            ProjectLocationTarget = 1,
        }

        private static gax::PathTemplate s_projectLocationTarget = new gax::PathTemplate("projects/{project}/locations/{location}/targets/{target}");

        /// <summary>Creates a <see cref="TargetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TargetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TargetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TargetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TargetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetId">The <c>Target</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TargetName"/> constructed from the provided ids.</returns>
        public static TargetName FromProjectLocationTarget(string projectId, string locationId, string targetId) =>
            new TargetName(ResourceNameType.ProjectLocationTarget, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), targetId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetId">The <c>Target</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string targetId) =>
            FormatProjectLocationTarget(projectId, locationId, targetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetId">The <c>Target</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>.
        /// </returns>
        public static string FormatProjectLocationTarget(string projectId, string locationId, string targetId) =>
            s_projectLocationTarget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)));

        /// <summary>Parses the given resource name string into a new <see cref="TargetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/targets/{target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="targetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TargetName"/> if successful.</returns>
        public static TargetName Parse(string targetName) => Parse(targetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/targets/{target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TargetName"/> if successful.</returns>
        public static TargetName Parse(string targetName, bool allowUnparsed) =>
            TryParse(targetName, allowUnparsed, out TargetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/targets/{target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="targetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetName, out TargetName result) => TryParse(targetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/targets/{target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetName, bool allowUnparsed, out TargetName result)
        {
            gax::GaxPreconditions.CheckNotNull(targetName, nameof(targetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTarget.TryParseName(targetName, out resourceName))
            {
                result = FromProjectLocationTarget(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(targetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TargetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string targetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TargetId = targetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TargetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/targets/{target}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetId">The <c>Target</c> ID. Must not be <c>null</c> or empty.</param>
        public TargetName(string projectId, string locationId, string targetId) : this(ResourceNameType.ProjectLocationTarget, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), targetId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Target</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TargetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTarget: return s_projectLocationTarget.Expand(ProjectId, LocationId, TargetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TargetName);

        /// <inheritdoc/>
        public bool Equals(TargetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TargetName a, TargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TargetName a, TargetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Release</c> resource.</summary>
    public sealed partial class ReleaseName : gax::IResourceName, sys::IEquatable<ReleaseName>
    {
        /// <summary>The possible contents of <see cref="ReleaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
            /// </summary>
            ProjectLocationDeliveryPipelineRelease = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipelineRelease = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}");

        /// <summary>Creates a <see cref="ReleaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReleaseName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReleaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReleaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReleaseName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReleaseName"/> constructed from the provided ids.</returns>
        public static ReleaseName FromProjectLocationDeliveryPipelineRelease(string projectId, string locationId, string deliveryPipelineId, string releaseId) =>
            new ReleaseName(ResourceNameType.ProjectLocationDeliveryPipelineRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId, string releaseId) =>
            FormatProjectLocationDeliveryPipelineRelease(projectId, locationId, deliveryPipelineId, releaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReleaseName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>.
        /// </returns>
        public static string FormatProjectLocationDeliveryPipelineRelease(string projectId, string locationId, string deliveryPipelineId, string releaseId) =>
            s_projectLocationDeliveryPipelineRelease.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReleaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName) => Parse(releaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReleaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReleaseName"/> if successful.</returns>
        public static ReleaseName Parse(string releaseName, bool allowUnparsed) =>
            TryParse(releaseName, allowUnparsed, out ReleaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, out ReleaseName result) => TryParse(releaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReleaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="releaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReleaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string releaseName, bool allowUnparsed, out ReleaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(releaseName, nameof(releaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipelineRelease.TryParseName(releaseName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipelineRelease(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(releaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReleaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deliveryPipelineId = null, string locationId = null, string projectId = null, string releaseId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeliveryPipelineId = deliveryPipelineId;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReleaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        public ReleaseName(string projectId, string locationId, string deliveryPipelineId, string releaseId) : this(ResourceNameType.ProjectLocationDeliveryPipelineRelease, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)))
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
        /// The <c>DeliveryPipeline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DeliveryPipelineId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Release</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReleaseId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDeliveryPipelineRelease: return s_projectLocationDeliveryPipelineRelease.Expand(ProjectId, LocationId, DeliveryPipelineId, ReleaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReleaseName);

        /// <inheritdoc/>
        public bool Equals(ReleaseName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReleaseName a, ReleaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReleaseName a, ReleaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Rollout</c> resource.</summary>
    public sealed partial class RolloutName : gax::IResourceName, sys::IEquatable<RolloutName>
    {
        /// <summary>The possible contents of <see cref="RolloutName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
            /// .
            /// </summary>
            ProjectLocationDeliveryPipelineReleaseRollout = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipelineReleaseRollout = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}");

        /// <summary>Creates a <see cref="RolloutName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RolloutName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RolloutName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RolloutName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RolloutName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RolloutName"/> constructed from the provided ids.</returns>
        public static RolloutName FromProjectLocationDeliveryPipelineReleaseRollout(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId) =>
            new RolloutName(ResourceNameType.ProjectLocationDeliveryPipelineReleaseRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId) =>
            FormatProjectLocationDeliveryPipelineReleaseRollout(projectId, locationId, deliveryPipelineId, releaseId, rolloutId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDeliveryPipelineReleaseRollout(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId) =>
            s_projectLocationDeliveryPipelineReleaseRollout.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>Parses the given resource name string into a new <see cref="RolloutName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName) => Parse(rolloutName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RolloutName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName, bool allowUnparsed) =>
            TryParse(rolloutName, allowUnparsed, out RolloutName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, out RolloutName result) => TryParse(rolloutName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, bool allowUnparsed, out RolloutName result)
        {
            gax::GaxPreconditions.CheckNotNull(rolloutName, nameof(rolloutName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipelineReleaseRollout.TryParseName(rolloutName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipelineReleaseRollout(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rolloutName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RolloutName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deliveryPipelineId = null, string locationId = null, string projectId = null, string releaseId = null, string rolloutId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeliveryPipelineId = deliveryPipelineId;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
            RolloutId = rolloutId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RolloutName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        public RolloutName(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId) : this(ResourceNameType.ProjectLocationDeliveryPipelineReleaseRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)))
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
        /// The <c>DeliveryPipeline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DeliveryPipelineId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Release</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReleaseId { get; }

        /// <summary>
        /// The <c>Rollout</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RolloutId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDeliveryPipelineReleaseRollout: return s_projectLocationDeliveryPipelineReleaseRollout.Expand(ProjectId, LocationId, DeliveryPipelineId, ReleaseId, RolloutId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RolloutName);

        /// <inheritdoc/>
        public bool Equals(RolloutName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RolloutName a, RolloutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RolloutName a, RolloutName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Config</c> resource.</summary>
    public sealed partial class ConfigName : gax::IResourceName, sys::IEquatable<ConfigName>
    {
        /// <summary>The possible contents of <see cref="ConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}/config</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/config");

        /// <summary>Creates a <see cref="ConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConfigName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConfigName"/> with the pattern <c>projects/{project}/locations/{location}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConfigName"/> constructed from the provided ids.</returns>
        public static ConfigName FromProjectLocation(string projectId, string locationId) =>
            new ConfigName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/config</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/config</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/config</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="configName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConfigName"/> if successful.</returns>
        public static ConfigName Parse(string configName) => Parse(configName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConfigName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/config</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="configName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConfigName"/> if successful.</returns>
        public static ConfigName Parse(string configName, bool allowUnparsed) =>
            TryParse(configName, allowUnparsed, out ConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/config</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="configName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string configName, out ConfigName result) => TryParse(configName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/config</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="configName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string configName, bool allowUnparsed, out ConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(configName, nameof(configName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(configName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(configName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/config</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public ConfigName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConfigName);

        /// <inheritdoc/>
        public bool Equals(ConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConfigName a, ConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConfigName a, ConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Build</c> resource.</summary>
    public sealed partial class BuildName : gax::IResourceName, sys::IEquatable<BuildName>
    {
        /// <summary>The possible contents of <see cref="BuildName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/builds/{build}</c>.
            /// </summary>
            ProjectLocationBuild = 1,
        }

        private static gax::PathTemplate s_projectLocationBuild = new gax::PathTemplate("projects/{project}/locations/{location}/builds/{build}");

        /// <summary>Creates a <see cref="BuildName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildName"/> with the pattern <c>projects/{project}/locations/{location}/builds/{build}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildName"/> constructed from the provided ids.</returns>
        public static BuildName FromProjectLocationBuild(string projectId, string locationId, string buildId) =>
            new BuildName(ResourceNameType.ProjectLocationBuild, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string buildId) =>
            FormatProjectLocationBuild(projectId, locationId, buildId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </returns>
        public static string FormatProjectLocationBuild(string projectId, string locationId, string buildId) =>
            s_projectLocationBuild.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>Parses the given resource name string into a new <see cref="BuildName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName) => Parse(buildName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName, bool allowUnparsed) =>
            TryParse(buildName, allowUnparsed, out BuildName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, out BuildName result) => TryParse(buildName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, bool allowUnparsed, out BuildName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildName, nameof(buildName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBuild.TryParseName(buildName, out resourceName))
            {
                result = FromProjectLocationBuild(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string buildId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BuildId = buildId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildName(string projectId, string locationId, string buildId) : this(ResourceNameType.ProjectLocationBuild, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)))
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
        /// The <c>Build</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BuildId { get; }

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
                case ResourceNameType.ProjectLocationBuild: return s_projectLocationBuild.Expand(ProjectId, LocationId, BuildId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildName);

        /// <inheritdoc/>
        public bool Equals(BuildName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BuildName a, BuildName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BuildName a, BuildName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Cluster</c> resource.</summary>
    public sealed partial class ClusterName : gax::IResourceName, sys::IEquatable<ClusterName>
    {
        /// <summary>The possible contents of <see cref="ClusterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
            /// </summary>
            ProjectLocationCluster = 1,
        }

        private static gax::PathTemplate s_projectLocationCluster = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}");

        /// <summary>Creates a <see cref="ClusterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClusterName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClusterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClusterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClusterName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClusterName"/> constructed from the provided ids.</returns>
        public static ClusterName FromProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            new ClusterName(ResourceNameType.ProjectLocationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId) =>
            FormatProjectLocationCluster(projectId, locationId, clusterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClusterName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>.
        /// </returns>
        public static string FormatProjectLocationCluster(string projectId, string locationId, string clusterId) =>
            s_projectLocationCluster.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)));

        /// <summary>Parses the given resource name string into a new <see cref="ClusterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClusterName"/> if successful.</returns>
        public static ClusterName Parse(string clusterName) => Parse(clusterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClusterName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClusterName"/> if successful.</returns>
        public static ClusterName Parse(string clusterName, bool allowUnparsed) =>
            TryParse(clusterName, allowUnparsed, out ClusterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterName, out ClusterName result) => TryParse(clusterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClusterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/clusters/{cluster}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clusterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClusterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterName, bool allowUnparsed, out ClusterName result)
        {
            gax::GaxPreconditions.CheckNotNull(clusterName, nameof(clusterName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCluster.TryParseName(clusterName, out resourceName))
            {
                result = FromProjectLocationCluster(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clusterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClusterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClusterName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        public ClusterName(string projectId, string locationId, string clusterId) : this(ResourceNameType.ProjectLocationCluster, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)))
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
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

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
                case ResourceNameType.ProjectLocationCluster: return s_projectLocationCluster.Expand(ProjectId, LocationId, ClusterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClusterName);

        /// <inheritdoc/>
        public bool Equals(ClusterName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ClusterName a, ClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ClusterName a, ClusterName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Operation</c> resource.</summary>
    public sealed partial class OperationName : gax::IResourceName, sys::IEquatable<OperationName>
    {
        /// <summary>The possible contents of <see cref="OperationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/operations/{operation}</c>.
            /// </summary>
            ProjectLocationOperation = 1,
        }

        private static gax::PathTemplate s_projectLocationOperation = new gax::PathTemplate("projects/{project}/locations/{location}/operations/{operation}");

        /// <summary>Creates a <see cref="OperationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OperationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OperationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OperationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OperationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OperationName"/> constructed from the provided ids.</returns>
        public static OperationName FromProjectLocationOperation(string projectId, string locationId, string operationId) =>
            new OperationName(ResourceNameType.ProjectLocationOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string operationId) =>
            FormatProjectLocationOperation(projectId, locationId, operationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>.
        /// </returns>
        public static string FormatProjectLocationOperation(string projectId, string locationId, string operationId) =>
            s_projectLocationOperation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>Parses the given resource name string into a new <see cref="OperationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName) => Parse(operationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName, bool allowUnparsed) =>
            TryParse(operationName, allowUnparsed, out OperationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, out OperationName result) => TryParse(operationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, bool allowUnparsed, out OperationName result)
        {
            gax::GaxPreconditions.CheckNotNull(operationName, nameof(operationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOperation.TryParseName(operationName, out resourceName))
            {
                result = FromProjectLocationOperation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(operationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OperationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string operationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OperationId = operationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OperationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/operations/{operation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        public OperationName(string projectId, string locationId, string operationId) : this(ResourceNameType.ProjectLocationOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)))
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
        /// The <c>Operation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OperationId { get; }

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
                case ResourceNameType.ProjectLocationOperation: return s_projectLocationOperation.Expand(ProjectId, LocationId, OperationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OperationName);

        /// <inheritdoc/>
        public bool Equals(OperationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OperationName a, OperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OperationName a, OperationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkerPool</c> resource.</summary>
    public sealed partial class WorkerPoolName : gax::IResourceName, sys::IEquatable<WorkerPoolName>
    {
        /// <summary>The possible contents of <see cref="WorkerPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
            /// </summary>
            ProjectLocationWorkerPool = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkerPool = new gax::PathTemplate("projects/{project}/locations/{location}/workerPools/{worker_pool}");

        /// <summary>Creates a <see cref="WorkerPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkerPoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkerPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkerPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkerPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkerPoolName"/> constructed from the provided ids.</returns>
        public static WorkerPoolName FromProjectLocationWorkerPool(string projectId, string locationId, string workerPoolId) =>
            new WorkerPoolName(ResourceNameType.ProjectLocationWorkerPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workerPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workerPoolId) =>
            FormatProjectLocationWorkerPool(projectId, locationId, workerPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkerPool(string projectId, string locationId, string workerPoolId) =>
            s_projectLocationWorkerPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkerPoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkerPoolName"/> if successful.</returns>
        public static WorkerPoolName Parse(string workerPoolName) => Parse(workerPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkerPoolName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkerPoolName"/> if successful.</returns>
        public static WorkerPoolName Parse(string workerPoolName, bool allowUnparsed) =>
            TryParse(workerPoolName, allowUnparsed, out WorkerPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkerPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkerPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workerPoolName, out WorkerPoolName result) =>
            TryParse(workerPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkerPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkerPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workerPoolName, bool allowUnparsed, out WorkerPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(workerPoolName, nameof(workerPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkerPool.TryParseName(workerPoolName, out resourceName))
            {
                result = FromProjectLocationWorkerPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workerPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkerPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workerPoolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkerPoolId = workerPoolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkerPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkerPoolName(string projectId, string locationId, string workerPoolId) : this(ResourceNameType.ProjectLocationWorkerPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workerPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>WorkerPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkerPoolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkerPool: return s_projectLocationWorkerPool.Expand(ProjectId, LocationId, WorkerPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkerPoolName);

        /// <inheritdoc/>
        public bool Equals(WorkerPoolName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WorkerPoolName a, WorkerPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WorkerPoolName a, WorkerPoolName b) => !(a == b);
    }

    public partial class DeliveryPipeline
    {
        /// <summary>
        /// <see cref="gcdv::DeliveryPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeliveryPipelineName DeliveryPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeliveryPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TargetsPresentCondition
    {
        /// <summary>
        /// <see cref="TargetName"/>-typed view over the <see cref="MissingTargets"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TargetName> MissingTargetsAsTargetNames
        {
            get => new gax::ResourceNameList<TargetName>(MissingTargets, s => string.IsNullOrEmpty(s) ? null : TargetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ListDeliveryPipelinesRequest
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

    public partial class GetDeliveryPipelineRequest
    {
        /// <summary>
        /// <see cref="gcdv::DeliveryPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeliveryPipelineName DeliveryPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeliveryPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeliveryPipelineRequest
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

    public partial class DeleteDeliveryPipelineRequest
    {
        /// <summary>
        /// <see cref="gcdv::DeliveryPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeliveryPipelineName DeliveryPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeliveryPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Target
    {
        /// <summary>
        /// <see cref="gcdv::TargetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetName TargetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PrivatePool
    {
        /// <summary>
        /// <see cref="WorkerPoolName"/>-typed view over the <see cref="WorkerPool"/> resource name property.
        /// </summary>
        public WorkerPoolName WorkerPoolAsWorkerPoolName
        {
            get => string.IsNullOrEmpty(WorkerPool) ? null : WorkerPoolName.Parse(WorkerPool, allowUnparsed: true);
            set => WorkerPool = value?.ToString() ?? "";
        }
    }

    public partial class GkeCluster
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Cluster"/> resource name property.
        /// </summary>
        public ClusterName ClusterAsClusterName
        {
            get => string.IsNullOrEmpty(Cluster) ? null : ClusterName.Parse(Cluster, allowUnparsed: true);
            set => Cluster = value?.ToString() ?? "";
        }
    }

    public partial class ListTargetsRequest
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

    public partial class GetTargetRequest
    {
        /// <summary>
        /// <see cref="gcdv::TargetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetName TargetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTargetRequest
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

    public partial class DeleteTargetRequest
    {
        /// <summary>
        /// <see cref="gcdv::TargetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetName TargetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Release
    {
        /// <summary>
        /// <see cref="gcdv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReleasesRequest
    {
        /// <summary>
        /// <see cref="DeliveryPipelineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DeliveryPipelineName ParentAsDeliveryPipelineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DeliveryPipelineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReleaseRequest
    {
        /// <summary>
        /// <see cref="gcdv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReleaseRequest
    {
        /// <summary>
        /// <see cref="DeliveryPipelineName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DeliveryPipelineName ParentAsDeliveryPipelineName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DeliveryPipelineName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Rollout
    {
        /// <summary>
        /// <see cref="gcdv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BuildName"/>-typed view over the <see cref="DeployingBuild"/> resource name property.
        /// </summary>
        public BuildName DeployingBuildAsBuildName
        {
            get => string.IsNullOrEmpty(DeployingBuild) ? null : BuildName.Parse(DeployingBuild, allowUnparsed: true);
            set => DeployingBuild = value?.ToString() ?? "";
        }
    }

    public partial class ListRolloutsRequest
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReleaseName ParentAsReleaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReleaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetRolloutRequest
    {
        /// <summary>
        /// <see cref="gcdv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRolloutRequest
    {
        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ReleaseName ParentAsReleaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReleaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ApproveRolloutRequest
    {
        /// <summary>
        /// <see cref="gcdv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Config
    {
        /// <summary>
        /// <see cref="gcdv::ConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConfigName ConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetConfigRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConfigName ConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
