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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gclv = Google.Cloud.LicenseManager.V1;
using sys = System;

namespace Google.Cloud.LicenseManager.V1
{
    /// <summary>Resource name for the <c>ComputeInstance</c> resource.</summary>
    public sealed partial class ComputeInstanceName : gax::IResourceName, sys::IEquatable<ComputeInstanceName>
    {
        /// <summary>The possible contents of <see cref="ComputeInstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
            /// </summary>
            ProjectZoneInstance = 1,
        }

        private static gax::PathTemplate s_projectZoneInstance = new gax::PathTemplate("projects/{project}/zones/{zone}/instances/{instance}");

        /// <summary>Creates a <see cref="ComputeInstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ComputeInstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ComputeInstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ComputeInstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ComputeInstanceName"/> with the pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ComputeInstanceName"/> constructed from the provided ids.</returns>
        public static ComputeInstanceName FromProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            new ComputeInstanceName(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string zoneId, string instanceId) =>
            FormatProjectZoneInstance(projectId, zoneId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ComputeInstanceName"/> with pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectZoneInstance(string projectId, string zoneId, string instanceId) =>
            s_projectZoneInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComputeInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ComputeInstanceName"/> if successful.</returns>
        public static ComputeInstanceName Parse(string computeInstanceName) => Parse(computeInstanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ComputeInstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ComputeInstanceName"/> if successful.</returns>
        public static ComputeInstanceName Parse(string computeInstanceName, bool allowUnparsed) =>
            TryParse(computeInstanceName, allowUnparsed, out ComputeInstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComputeInstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComputeInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string computeInstanceName, out ComputeInstanceName result) =>
            TryParse(computeInstanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ComputeInstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/zones/{zone}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="computeInstanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ComputeInstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string computeInstanceName, bool allowUnparsed, out ComputeInstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(computeInstanceName, nameof(computeInstanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectZoneInstance.TryParseName(computeInstanceName, out resourceName))
            {
                result = FromProjectZoneInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(computeInstanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ComputeInstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ComputeInstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/zones/{zone}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public ComputeInstanceName(string projectId, string zoneId, string instanceId) : this(ResourceNameType.ProjectZoneInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectZoneInstance: return s_projectZoneInstance.Expand(ProjectId, ZoneId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ComputeInstanceName);

        /// <inheritdoc/>
        public bool Equals(ComputeInstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ComputeInstanceName a, ComputeInstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ComputeInstanceName a, ComputeInstanceName b) => !(a == b);
    }

    public partial class ListConfigurationsRequest
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

    public partial class GetConfigurationRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConfigurationRequest
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

    public partial class DeleteConfigurationRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
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

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gclv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QueryConfigurationLicenseUsageRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeactivateConfigurationRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReactivateConfigurationRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AggregateUsageRequest
    {
        /// <summary>
        /// <see cref="gclv::ConfigurationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ConfigurationName ConfigurationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ConfigurationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsRequest
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

    public partial class GetProductRequest
    {
        /// <summary>
        /// <see cref="gclv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
