// Copyright 2019 Google LLC
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
using gcrv = Google.Cloud.Redis.V1;
using sys = System;

namespace Google.Cloud.Redis.V1
{
    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}");

        /// <summary>
        /// Parses the given <c>Instance</c> resource name in string form into a new <see cref="InstanceName"/>
        /// instance.
        /// </summary>
        /// <param name="instanceName">
        /// The <c>Instance</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(instanceName);
            return new InstanceName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="InstanceName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="instanceName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceName">
        /// The <c>Instance</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            if (s_template.TryParseName(instanceName, out gax::TemplatedResourceName resourceName))
            {
                result = new InstanceName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="InstanceName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="InstanceName"/>.</returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c>.</param>
        public InstanceName(string projectId, string locationId, string instanceId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            InstanceId = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Instance</c> ID. Never <c>null</c>.</summary>
        public string InstanceId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, InstanceId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc/>
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcrv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcrv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcrv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FailoverInstanceRequest
    {
        /// <summary>
        /// <see cref="gcrv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
