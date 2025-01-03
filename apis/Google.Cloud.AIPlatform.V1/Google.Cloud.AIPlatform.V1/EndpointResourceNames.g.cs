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
    /// <summary>Resource name for the <c>Endpoint</c> resource.</summary>
    public sealed partial class EndpointName : gax::IResourceName, sys::IEquatable<EndpointName>
    {
        /// <summary>The possible contents of <see cref="EndpointName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
            /// </summary>
            ProjectLocationEndpoint = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>.
            /// </summary>
            ProjectLocationPublisherModel = 2,
        }

        private static gax::PathTemplate s_projectLocationEndpoint = new gax::PathTemplate("projects/{project}/locations/{location}/endpoints/{endpoint}");

        private static gax::PathTemplate s_projectLocationPublisherModel = new gax::PathTemplate("projects/{project}/locations/{location}/publishers/{publisher}/models/{model}");

        /// <summary>Creates a <see cref="EndpointName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EndpointName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static EndpointName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EndpointName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EndpointName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EndpointName"/> constructed from the provided ids.</returns>
        public static EndpointName FromProjectLocationEndpoint(string projectId, string locationId, string endpointId) =>
            new EndpointName(ResourceNameType.ProjectLocationEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), endpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)));

        /// <summary>
        /// Creates a <see cref="EndpointName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EndpointName"/> constructed from the provided ids.</returns>
        public static EndpointName FromProjectLocationPublisherModel(string projectId, string locationId, string publisherId, string modelId) =>
            new EndpointName(ResourceNameType.ProjectLocationPublisherModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string endpointId) =>
            FormatProjectLocationEndpoint(projectId, locationId, endpointId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>.
        /// </returns>
        public static string FormatProjectLocationEndpoint(string projectId, string locationId, string endpointId) =>
            s_projectLocationEndpoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>.
        /// </returns>
        public static string FormatProjectLocationPublisherModel(string projectId, string locationId, string publisherId, string modelId) =>
            s_projectLocationPublisherModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>Parses the given resource name string into a new <see cref="EndpointName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/endpoints/{endpoint}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EndpointName"/> if successful.</returns>
        public static EndpointName Parse(string endpointName) => Parse(endpointName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EndpointName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/endpoints/{endpoint}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EndpointName"/> if successful.</returns>
        public static EndpointName Parse(string endpointName, bool allowUnparsed) =>
            TryParse(endpointName, allowUnparsed, out EndpointName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/endpoints/{endpoint}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointName, out EndpointName result) => TryParse(endpointName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/endpoints/{endpoint}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}/models/{model}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointName, bool allowUnparsed, out EndpointName result)
        {
            gax::GaxPreconditions.CheckNotNull(endpointName, nameof(endpointName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEndpoint.TryParseName(endpointName, out resourceName))
            {
                result = FromProjectLocationEndpoint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationPublisherModel.TryParseName(endpointName, out resourceName))
            {
                result = FromProjectLocationPublisherModel(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(endpointName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EndpointName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string endpointId = null, string locationId = null, string modelId = null, string projectId = null, string publisherId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EndpointId = endpointId;
            LocationId = locationId;
            ModelId = modelId;
            ProjectId = projectId;
            PublisherId = publisherId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EndpointName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/endpoints/{endpoint}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointId">The <c>Endpoint</c> ID. Must not be <c>null</c> or empty.</param>
        public EndpointName(string projectId, string locationId, string endpointId) : this(ResourceNameType.ProjectLocationEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), endpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)))
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
        /// The <c>Endpoint</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string EndpointId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Model</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Publisher</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string PublisherId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationEndpoint: return s_projectLocationEndpoint.Expand(ProjectId, LocationId, EndpointId);
                case ResourceNameType.ProjectLocationPublisherModel: return s_projectLocationPublisherModel.Expand(ProjectId, LocationId, PublisherId, ModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EndpointName);

        /// <inheritdoc/>
        public bool Equals(EndpointName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EndpointName a, EndpointName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EndpointName a, EndpointName b) => !(a == b);
    }

    public partial class Endpoint
    {
        /// <summary>
        /// <see cref="gcav::EndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EndpointName EndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EndpointName.Parse(Name, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="ModelDeploymentMonitoringJobName"/>-typed view over the
        /// <see cref="ModelDeploymentMonitoringJob"/> resource name property.
        /// </summary>
        public ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(ModelDeploymentMonitoringJob) ? null : ModelDeploymentMonitoringJobName.Parse(ModelDeploymentMonitoringJob, allowUnparsed: true);
            set => ModelDeploymentMonitoringJob = value?.ToString() ?? "";
        }
    }

    public partial class DeployedModel
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DeploymentResourcePoolName"/>-typed view over the <see cref="SharedResources"/> resource name
        /// property.
        /// </summary>
        public DeploymentResourcePoolName SharedResourcesAsDeploymentResourcePoolName
        {
            get => string.IsNullOrEmpty(SharedResources) ? null : DeploymentResourcePoolName.Parse(SharedResources, allowUnparsed: true);
            set => SharedResources = value?.ToString() ?? "";
        }
    }
}
