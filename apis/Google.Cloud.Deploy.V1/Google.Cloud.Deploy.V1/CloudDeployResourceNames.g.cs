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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeliveryPipelineName a, DeliveryPipelineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TargetName a, TargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TargetName a, TargetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CustomTargetType</c> resource.</summary>
    public sealed partial class CustomTargetTypeName : gax::IResourceName, sys::IEquatable<CustomTargetTypeName>
    {
        /// <summary>The possible contents of <see cref="CustomTargetTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
            /// </summary>
            ProjectLocationCustomTargetType = 1,
        }

        private static gax::PathTemplate s_projectLocationCustomTargetType = new gax::PathTemplate("projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}");

        /// <summary>Creates a <see cref="CustomTargetTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomTargetTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomTargetTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomTargetTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomTargetTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetTypeId">The <c>CustomTargetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomTargetTypeName"/> constructed from the provided ids.</returns>
        public static CustomTargetTypeName FromProjectLocationCustomTargetType(string projectId, string locationId, string customTargetTypeId) =>
            new CustomTargetTypeName(ResourceNameType.ProjectLocationCustomTargetType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customTargetTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomTargetTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetTypeId">The <c>CustomTargetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomTargetTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string customTargetTypeId) =>
            FormatProjectLocationCustomTargetType(projectId, locationId, customTargetTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomTargetTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetTypeId">The <c>CustomTargetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomTargetTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>.
        /// </returns>
        public static string FormatProjectLocationCustomTargetType(string projectId, string locationId, string customTargetTypeId) =>
            s_projectLocationCustomTargetType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomTargetTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customTargetTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomTargetTypeName"/> if successful.</returns>
        public static CustomTargetTypeName Parse(string customTargetTypeName) => Parse(customTargetTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomTargetTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customTargetTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomTargetTypeName"/> if successful.</returns>
        public static CustomTargetTypeName Parse(string customTargetTypeName, bool allowUnparsed) =>
            TryParse(customTargetTypeName, allowUnparsed, out CustomTargetTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomTargetTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customTargetTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomTargetTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customTargetTypeName, out CustomTargetTypeName result) =>
            TryParse(customTargetTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomTargetTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customTargetTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomTargetTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customTargetTypeName, bool allowUnparsed, out CustomTargetTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(customTargetTypeName, nameof(customTargetTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCustomTargetType.TryParseName(customTargetTypeName, out resourceName))
            {
                result = FromProjectLocationCustomTargetType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customTargetTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomTargetTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customTargetTypeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomTargetTypeId = customTargetTypeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomTargetTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/customTargetTypes/{custom_target_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customTargetTypeId">The <c>CustomTargetType</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomTargetTypeName(string projectId, string locationId, string customTargetTypeId) : this(ResourceNameType.ProjectLocationCustomTargetType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customTargetTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)))
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
        /// The <c>CustomTargetType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomTargetTypeId { get; }

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
                case ResourceNameType.ProjectLocationCustomTargetType: return s_projectLocationCustomTargetType.Expand(ProjectId, LocationId, CustomTargetTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomTargetTypeName);

        /// <inheritdoc/>
        public bool Equals(CustomTargetTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomTargetTypeName a, CustomTargetTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomTargetTypeName a, CustomTargetTypeName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReleaseName a, ReleaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RolloutName a, RolloutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RolloutName a, RolloutName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>JobRun</c> resource.</summary>
    public sealed partial class JobRunName : gax::IResourceName, sys::IEquatable<JobRunName>
    {
        /// <summary>The possible contents of <see cref="JobRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
            /// .
            /// </summary>
            ProjectLocationDeliveryPipelineReleaseRolloutJobRun = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipelineReleaseRolloutJobRun = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}");

        /// <summary>Creates a <see cref="JobRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="JobRunName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static JobRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new JobRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="JobRunName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobRunId">The <c>JobRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobRunName"/> constructed from the provided ids.</returns>
        public static JobRunName FromProjectLocationDeliveryPipelineReleaseRolloutJobRun(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId, string jobRunId) =>
            new JobRunName(ResourceNameType.ProjectLocationDeliveryPipelineReleaseRolloutJobRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)), jobRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobRunId, nameof(jobRunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobRunId">The <c>JobRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId, string jobRunId) =>
            FormatProjectLocationDeliveryPipelineReleaseRolloutJobRun(projectId, locationId, deliveryPipelineId, releaseId, rolloutId, jobRunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobRunId">The <c>JobRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDeliveryPipelineReleaseRolloutJobRun(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId, string jobRunId) =>
            s_projectLocationDeliveryPipelineReleaseRolloutJobRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobRunId, nameof(jobRunId)));

        /// <summary>Parses the given resource name string into a new <see cref="JobRunName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jobRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobRunName"/> if successful.</returns>
        public static JobRunName Parse(string jobRunName) => Parse(jobRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="JobRunName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="JobRunName"/> if successful.</returns>
        public static JobRunName Parse(string jobRunName, bool allowUnparsed) =>
            TryParse(jobRunName, allowUnparsed, out JobRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jobRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobRunName, out JobRunName result) => TryParse(jobRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobRunName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobRunName, bool allowUnparsed, out JobRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobRunName, nameof(jobRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipelineReleaseRolloutJobRun.TryParseName(jobRunName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipelineReleaseRolloutJobRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(jobRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private JobRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deliveryPipelineId = null, string jobRunId = null, string locationId = null, string projectId = null, string releaseId = null, string rolloutId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeliveryPipelineId = deliveryPipelineId;
            JobRunId = jobRunId;
            LocationId = locationId;
            ProjectId = projectId;
            ReleaseId = releaseId;
            RolloutId = rolloutId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="JobRunName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{job_run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="releaseId">The <c>Release</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobRunId">The <c>JobRun</c> ID. Must not be <c>null</c> or empty.</param>
        public JobRunName(string projectId, string locationId, string deliveryPipelineId, string releaseId, string rolloutId, string jobRunId) : this(ResourceNameType.ProjectLocationDeliveryPipelineReleaseRolloutJobRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), releaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)), jobRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobRunId, nameof(jobRunId)))
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
        /// The <c>JobRun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string JobRunId { get; }

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
                case ResourceNameType.ProjectLocationDeliveryPipelineReleaseRolloutJobRun: return s_projectLocationDeliveryPipelineReleaseRolloutJobRun.Expand(ProjectId, LocationId, DeliveryPipelineId, ReleaseId, RolloutId, JobRunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as JobRunName);

        /// <inheritdoc/>
        public bool Equals(JobRunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(JobRunName a, JobRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(JobRunName a, JobRunName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConfigName a, ConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConfigName a, ConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Automation</c> resource.</summary>
    public sealed partial class AutomationName : gax::IResourceName, sys::IEquatable<AutomationName>
    {
        /// <summary>The possible contents of <see cref="AutomationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
            /// .
            /// </summary>
            ProjectLocationDeliveryPipelineAutomation = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipelineAutomation = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}");

        /// <summary>Creates a <see cref="AutomationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutomationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutomationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutomationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutomationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationId">The <c>Automation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutomationName"/> constructed from the provided ids.</returns>
        public static AutomationName FromProjectLocationDeliveryPipelineAutomation(string projectId, string locationId, string deliveryPipelineId, string automationId) =>
            new AutomationName(ResourceNameType.ProjectLocationDeliveryPipelineAutomation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), automationId: gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutomationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationId">The <c>Automation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutomationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId, string automationId) =>
            FormatProjectLocationDeliveryPipelineAutomation(projectId, locationId, deliveryPipelineId, automationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutomationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationId">The <c>Automation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutomationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDeliveryPipelineAutomation(string projectId, string locationId, string deliveryPipelineId, string automationId) =>
            s_projectLocationDeliveryPipelineAutomation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)));

        /// <summary>Parses the given resource name string into a new <see cref="AutomationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="automationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AutomationName"/> if successful.</returns>
        public static AutomationName Parse(string automationName) => Parse(automationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutomationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="automationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutomationName"/> if successful.</returns>
        public static AutomationName Parse(string automationName, bool allowUnparsed) =>
            TryParse(automationName, allowUnparsed, out AutomationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutomationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="automationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutomationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string automationName, out AutomationName result) =>
            TryParse(automationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutomationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="automationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutomationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string automationName, bool allowUnparsed, out AutomationName result)
        {
            gax::GaxPreconditions.CheckNotNull(automationName, nameof(automationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipelineAutomation.TryParseName(automationName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipelineAutomation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(automationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutomationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string automationId = null, string deliveryPipelineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutomationId = automationId;
            DeliveryPipelineId = deliveryPipelineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutomationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automations/{automation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationId">The <c>Automation</c> ID. Must not be <c>null</c> or empty.</param>
        public AutomationName(string projectId, string locationId, string deliveryPipelineId, string automationId) : this(ResourceNameType.ProjectLocationDeliveryPipelineAutomation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), automationId: gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)))
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
        /// The <c>Automation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AutomationId { get; }

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
                case ResourceNameType.ProjectLocationDeliveryPipelineAutomation: return s_projectLocationDeliveryPipelineAutomation.Expand(ProjectId, LocationId, DeliveryPipelineId, AutomationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutomationName);

        /// <inheritdoc/>
        public bool Equals(AutomationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AutomationName a, AutomationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AutomationName a, AutomationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AutomationRun</c> resource.</summary>
    public sealed partial class AutomationRunName : gax::IResourceName, sys::IEquatable<AutomationRunName>
    {
        /// <summary>The possible contents of <see cref="AutomationRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
            /// .
            /// </summary>
            ProjectLocationDeliveryPipelineAutomationRun = 1,
        }

        private static gax::PathTemplate s_projectLocationDeliveryPipelineAutomationRun = new gax::PathTemplate("projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}");

        /// <summary>Creates a <see cref="AutomationRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutomationRunName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutomationRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutomationRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutomationRunName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationRunId">The <c>AutomationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutomationRunName"/> constructed from the provided ids.</returns>
        public static AutomationRunName FromProjectLocationDeliveryPipelineAutomationRun(string projectId, string locationId, string deliveryPipelineId, string automationRunId) =>
            new AutomationRunName(ResourceNameType.ProjectLocationDeliveryPipelineAutomationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), automationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(automationRunId, nameof(automationRunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutomationRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationRunId">The <c>AutomationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutomationRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string deliveryPipelineId, string automationRunId) =>
            FormatProjectLocationDeliveryPipelineAutomationRun(projectId, locationId, deliveryPipelineId, automationRunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutomationRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationRunId">The <c>AutomationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutomationRunName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDeliveryPipelineAutomationRun(string projectId, string locationId, string deliveryPipelineId, string automationRunId) =>
            s_projectLocationDeliveryPipelineAutomationRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(automationRunId, nameof(automationRunId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutomationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="automationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AutomationRunName"/> if successful.</returns>
        public static AutomationRunName Parse(string automationRunName) => Parse(automationRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutomationRunName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="automationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutomationRunName"/> if successful.</returns>
        public static AutomationRunName Parse(string automationRunName, bool allowUnparsed) =>
            TryParse(automationRunName, allowUnparsed, out AutomationRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutomationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="automationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutomationRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string automationRunName, out AutomationRunName result) =>
            TryParse(automationRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutomationRunName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="automationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutomationRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string automationRunName, bool allowUnparsed, out AutomationRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(automationRunName, nameof(automationRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDeliveryPipelineAutomationRun.TryParseName(automationRunName, out resourceName))
            {
                result = FromProjectLocationDeliveryPipelineAutomationRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(automationRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutomationRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string automationRunId = null, string deliveryPipelineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutomationRunId = automationRunId;
            DeliveryPipelineId = deliveryPipelineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutomationRunName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deliveryPipelineId">The <c>DeliveryPipeline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="automationRunId">The <c>AutomationRun</c> ID. Must not be <c>null</c> or empty.</param>
        public AutomationRunName(string projectId, string locationId, string deliveryPipelineId, string automationRunId) : this(ResourceNameType.ProjectLocationDeliveryPipelineAutomationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deliveryPipelineId: gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)), automationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(automationRunId, nameof(automationRunId)))
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
        /// The <c>AutomationRun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AutomationRunId { get; }

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
                case ResourceNameType.ProjectLocationDeliveryPipelineAutomationRun: return s_projectLocationDeliveryPipelineAutomationRun.Expand(ProjectId, LocationId, DeliveryPipelineId, AutomationRunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutomationRunName);

        /// <inheritdoc/>
        public bool Equals(AutomationRunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AutomationRunName a, AutomationRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AutomationRunName a, AutomationRunName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BuildName a, BuildName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BuildName a, BuildName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Repository</c> resource.</summary>
    public sealed partial class RepositoryName : gax::IResourceName, sys::IEquatable<RepositoryName>
    {
        /// <summary>The possible contents of <see cref="RepositoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationConnectionRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionRepository = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}");

        /// <summary>Creates a <see cref="RepositoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RepositoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RepositoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RepositoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RepositoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId, string repositoryId) =>
            FormatProjectLocationConnectionRepository(projectId, locationId, connectionId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            s_projectLocationConnectionRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName) => Parse(repositoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RepositoryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName, bool allowUnparsed) =>
            TryParse(repositoryName, allowUnparsed, out RepositoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, out RepositoryName result) =>
            TryParse(repositoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, bool allowUnparsed, out RepositoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(repositoryName, nameof(repositoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationConnectionRepository(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(repositoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string connectionId, string repositoryId) : this(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationConnectionRepository: return s_projectLocationConnectionRepository.Expand(ProjectId, LocationId, ConnectionId, RepositoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RepositoryName);

        /// <inheritdoc/>
        public bool Equals(RepositoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RepositoryName a, RepositoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RepositoryName a, RepositoryName b) => !(a == b);
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ClusterName a, ClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OperationName a, OperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkerPoolName a, WorkerPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkerPoolName a, WorkerPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Membership</c> resource.</summary>
    public sealed partial class MembershipName : gax::IResourceName, sys::IEquatable<MembershipName>
    {
        /// <summary>The possible contents of <see cref="MembershipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
            /// </summary>
            ProjectLocationMembership = 1,
        }

        private static gax::PathTemplate s_projectLocationMembership = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{membership}");

        /// <summary>Creates a <see cref="MembershipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MembershipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MembershipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MembershipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MembershipName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MembershipName"/> constructed from the provided ids.</returns>
        public static MembershipName FromProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            new MembershipName(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string membershipId) =>
            FormatProjectLocationMembership(projectId, locationId, membershipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string FormatProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            s_projectLocationMembership.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>Parses the given resource name string into a new <see cref="MembershipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName) => Parse(membershipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName, bool allowUnparsed) =>
            TryParse(membershipName, allowUnparsed, out MembershipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, out MembershipName result) =>
            TryParse(membershipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, bool allowUnparsed, out MembershipName result)
        {
            gax::GaxPreconditions.CheckNotNull(membershipName, nameof(membershipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMembership.TryParseName(membershipName, out resourceName))
            {
                result = FromProjectLocationMembership(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(membershipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MembershipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string membershipId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MembershipId = membershipId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MembershipName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        public MembershipName(string projectId, string locationId, string membershipId) : this(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)))
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
        /// The <c>Membership</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MembershipId { get; }

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
                case ResourceNameType.ProjectLocationMembership: return s_projectLocationMembership.Expand(ProjectId, LocationId, MembershipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MembershipName);

        /// <inheritdoc/>
        public bool Equals(MembershipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MembershipName a, MembershipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MembershipName a, MembershipName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/services/{service}</c>.
            /// </summary>
            ProjectLocationService = 1,
        }

        private static gax::PathTemplate s_projectLocationService = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromProjectLocationService(string projectId, string locationId, string serviceId) =>
            new ServiceName(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId) =>
            FormatProjectLocationService(projectId, locationId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationService(string projectId, string locationId, string serviceId) =>
            s_projectLocationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/services/{service}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationService.TryParseName(serviceName, out resourceName))
            {
                result = FromProjectLocationService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string projectId, string locationId, string serviceId) : this(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationService: return s_projectLocationService.Expand(ProjectId, LocationId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Job</c> resource.</summary>
    public sealed partial class JobName : gax::IResourceName, sys::IEquatable<JobName>
    {
        /// <summary>The possible contents of <see cref="JobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/jobs/{job}</c>.
            /// </summary>
            ProjectLocationJob = 1,
        }

        private static gax::PathTemplate s_projectLocationJob = new gax::PathTemplate("projects/{project}/locations/{location}/jobs/{job}");

        /// <summary>Creates a <see cref="JobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="JobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static JobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new JobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="JobName"/> with the pattern <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobName"/> constructed from the provided ids.</returns>
        public static JobName FromProjectLocationJob(string projectId, string locationId, string jobId) =>
            new JobName(ResourceNameType.ProjectLocationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string jobId) =>
            FormatProjectLocationJob(projectId, locationId, jobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </returns>
        public static string FormatProjectLocationJob(string projectId, string locationId, string jobId) =>
            s_projectLocationJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>Parses the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName) => Parse(jobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="JobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName, bool allowUnparsed) =>
            TryParse(jobName, allowUnparsed, out JobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, out JobName result) => TryParse(jobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, bool allowUnparsed, out JobName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobName, nameof(jobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationJob.TryParseName(jobName, out resourceName))
            {
                result = FromProjectLocationJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(jobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private JobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="JobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        public JobName(string projectId, string locationId, string jobId) : this(ResourceNameType.ProjectLocationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)))
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
        /// The <c>Job</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string JobId { get; }

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
                case ResourceNameType.ProjectLocationJob: return s_projectLocationJob.Expand(ProjectId, LocationId, JobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as JobName);

        /// <inheritdoc/>
        public bool Equals(JobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(JobName a, JobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(JobName a, JobName b) => !(a == b);
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

    public partial class RollbackTargetRequest
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

    public partial class ExecutionConfig
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

    public partial class AnthosCluster
    {
        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Membership"/> resource name property.
        /// </summary>
        public MembershipName MembershipAsMembershipName
        {
            get => string.IsNullOrEmpty(Membership) ? null : MembershipName.Parse(Membership, allowUnparsed: true);
            set => Membership = value?.ToString() ?? "";
        }
    }

    public partial class CloudRunLocation
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class CustomTarget
    {
        /// <summary>
        /// <see cref="CustomTargetTypeName"/>-typed view over the <see cref="CustomTargetType"/> resource name
        /// property.
        /// </summary>
        public CustomTargetTypeName CustomTargetTypeAsCustomTargetTypeName
        {
            get => string.IsNullOrEmpty(CustomTargetType) ? null : CustomTargetTypeName.Parse(CustomTargetType, allowUnparsed: true);
            set => CustomTargetType = value?.ToString() ?? "";
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

    public partial class CustomTargetType
    {
        /// <summary>
        /// <see cref="gcdv::CustomTargetTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CustomTargetTypeName CustomTargetTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CustomTargetTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SkaffoldModules
    {
        public partial class Types
        {
            public partial class SkaffoldGCBRepoSource
            {
                /// <summary>
                /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
                /// </summary>
                public RepositoryName RepositoryAsRepositoryName
                {
                    get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
                    set => Repository = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListCustomTargetTypesRequest
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

    public partial class GetCustomTargetTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::CustomTargetTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CustomTargetTypeName CustomTargetTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CustomTargetTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCustomTargetTypeRequest
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

    public partial class DeleteCustomTargetTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::CustomTargetTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CustomTargetTypeName CustomTargetTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CustomTargetTypeName.Parse(Name, allowUnparsed: true);
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

        public partial class Types
        {
            public partial class TargetRender
            {
                /// <summary>
                /// <see cref="BuildName"/>-typed view over the <see cref="RenderingBuild"/> resource name property.
                /// </summary>
                public BuildName RenderingBuildAsBuildName
                {
                    get => string.IsNullOrEmpty(RenderingBuild) ? null : BuildName.Parse(RenderingBuild, allowUnparsed: true);
                    set => RenderingBuild = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class CloudRunRenderMetadata
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
        /// </summary>
        public ServiceName ServiceAsServiceName
        {
            get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
            set => Service = value?.ToString() ?? "";
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

    public partial class CloudRunMetadata
    {
        /// <summary>
        /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
        /// </summary>
        public ServiceName ServiceAsServiceName
        {
            get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
            set => Service = value?.ToString() ?? "";
        }

        /// <summary><see cref="JobName"/>-typed view over the <see cref="Job"/> resource name property.</summary>
        public JobName JobAsJobName
        {
            get => string.IsNullOrEmpty(Job) ? null : JobName.Parse(Job, allowUnparsed: true);
            set => Job = value?.ToString() ?? "";
        }
    }

    public partial class Job
    {
        /// <summary><see cref="JobRunName"/>-typed view over the <see cref="JobRun"/> resource name property.</summary>
        public JobRunName JobRunAsJobRunName
        {
            get => string.IsNullOrEmpty(JobRun) ? null : JobRunName.Parse(JobRun, allowUnparsed: true);
            set => JobRun = value?.ToString() ?? "";
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

    public partial class AdvanceRolloutRequest
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

    public partial class CancelRolloutRequest
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

    public partial class IgnoreJobRequest
    {
        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="Rollout"/> resource name property.
        /// </summary>
        public RolloutName RolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(Rollout) ? null : RolloutName.Parse(Rollout, allowUnparsed: true);
            set => Rollout = value?.ToString() ?? "";
        }
    }

    public partial class RetryJobRequest
    {
        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="Rollout"/> resource name property.
        /// </summary>
        public RolloutName RolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(Rollout) ? null : RolloutName.Parse(Rollout, allowUnparsed: true);
            set => Rollout = value?.ToString() ?? "";
        }
    }

    public partial class AbandonReleaseRequest
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

    public partial class JobRun
    {
        /// <summary>
        /// <see cref="gcdv::JobRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobRunName JobRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployJobRun
    {
        /// <summary><see cref="BuildName"/>-typed view over the <see cref="Build"/> resource name property.</summary>
        public BuildName BuildAsBuildName
        {
            get => string.IsNullOrEmpty(Build) ? null : BuildName.Parse(Build, allowUnparsed: true);
            set => Build = value?.ToString() ?? "";
        }
    }

    public partial class VerifyJobRun
    {
        /// <summary><see cref="BuildName"/>-typed view over the <see cref="Build"/> resource name property.</summary>
        public BuildName BuildAsBuildName
        {
            get => string.IsNullOrEmpty(Build) ? null : BuildName.Parse(Build, allowUnparsed: true);
            set => Build = value?.ToString() ?? "";
        }
    }

    public partial class PredeployJobRun
    {
        /// <summary><see cref="BuildName"/>-typed view over the <see cref="Build"/> resource name property.</summary>
        public BuildName BuildAsBuildName
        {
            get => string.IsNullOrEmpty(Build) ? null : BuildName.Parse(Build, allowUnparsed: true);
            set => Build = value?.ToString() ?? "";
        }
    }

    public partial class PostdeployJobRun
    {
        /// <summary><see cref="BuildName"/>-typed view over the <see cref="Build"/> resource name property.</summary>
        public BuildName BuildAsBuildName
        {
            get => string.IsNullOrEmpty(Build) ? null : BuildName.Parse(Build, allowUnparsed: true);
            set => Build = value?.ToString() ?? "";
        }
    }

    public partial class ListJobRunsRequest
    {
        /// <summary>
        /// <see cref="RolloutName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RolloutName ParentAsRolloutName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RolloutName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetJobRunRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobRunName JobRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TerminateJobRunRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobRunName JobRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobRunName.Parse(Name, allowUnparsed: true);
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

    public partial class Automation
    {
        /// <summary>
        /// <see cref="gcdv::AutomationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationName AutomationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAutomationRequest
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

    public partial class DeleteAutomationRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutomationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationName AutomationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAutomationsRequest
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

    public partial class GetAutomationRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutomationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationName AutomationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AutomationRun
    {
        /// <summary>
        /// <see cref="gcdv::AutomationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationRunName AutomationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAutomationRunsRequest
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

    public partial class GetAutomationRunRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutomationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationRunName AutomationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelAutomationRunRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutomationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutomationRunName AutomationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutomationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
