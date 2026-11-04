// Copyright 2026 Google LLC
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
using gcsv = Google.Cloud.Sql.V1;
using sys = System;

namespace Google.Cloud.Sql.V1
{
    /// <summary>Resource name for the <c>BlueGreenDeployment</c> resource.</summary>
    public sealed partial class BlueGreenDeploymentName : gax::IResourceName, sys::IEquatable<BlueGreenDeploymentName>
    {
        /// <summary>The possible contents of <see cref="BlueGreenDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
            /// </summary>
            ProjectLocationBlueGreenDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationBlueGreenDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}");

        /// <summary>Creates a <see cref="BlueGreenDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BlueGreenDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BlueGreenDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BlueGreenDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BlueGreenDeploymentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="blueGreenDeploymentId">
        /// The <c>BlueGreenDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="BlueGreenDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static BlueGreenDeploymentName FromProjectLocationBlueGreenDeployment(string projectId, string locationId, string blueGreenDeploymentId) =>
            new BlueGreenDeploymentName(ResourceNameType.ProjectLocationBlueGreenDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), blueGreenDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BlueGreenDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="blueGreenDeploymentId">
        /// The <c>BlueGreenDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BlueGreenDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string blueGreenDeploymentId) =>
            FormatProjectLocationBlueGreenDeployment(projectId, locationId, blueGreenDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BlueGreenDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="blueGreenDeploymentId">
        /// The <c>BlueGreenDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BlueGreenDeploymentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>.
        /// </returns>
        public static string FormatProjectLocationBlueGreenDeployment(string projectId, string locationId, string blueGreenDeploymentId) =>
            s_projectLocationBlueGreenDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BlueGreenDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="blueGreenDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BlueGreenDeploymentName"/> if successful.</returns>
        public static BlueGreenDeploymentName Parse(string blueGreenDeploymentName) => Parse(blueGreenDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BlueGreenDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="blueGreenDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BlueGreenDeploymentName"/> if successful.</returns>
        public static BlueGreenDeploymentName Parse(string blueGreenDeploymentName, bool allowUnparsed) =>
            TryParse(blueGreenDeploymentName, allowUnparsed, out BlueGreenDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BlueGreenDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="blueGreenDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BlueGreenDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string blueGreenDeploymentName, out BlueGreenDeploymentName result) =>
            TryParse(blueGreenDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BlueGreenDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="blueGreenDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BlueGreenDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string blueGreenDeploymentName, bool allowUnparsed, out BlueGreenDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(blueGreenDeploymentName, nameof(blueGreenDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBlueGreenDeployment.TryParseName(blueGreenDeploymentName, out resourceName))
            {
                result = FromProjectLocationBlueGreenDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(blueGreenDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BlueGreenDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string blueGreenDeploymentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BlueGreenDeploymentId = blueGreenDeploymentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BlueGreenDeploymentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="blueGreenDeploymentId">
        /// The <c>BlueGreenDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public BlueGreenDeploymentName(string projectId, string locationId, string blueGreenDeploymentId) : this(ResourceNameType.ProjectLocationBlueGreenDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), blueGreenDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)))
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
        /// The <c>BlueGreenDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string BlueGreenDeploymentId { get; }

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
                case ResourceNameType.ProjectLocationBlueGreenDeployment: return s_projectLocationBlueGreenDeployment.Expand(ProjectId, LocationId, BlueGreenDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BlueGreenDeploymentName);

        /// <inheritdoc/>
        public bool Equals(BlueGreenDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BlueGreenDeploymentName a, BlueGreenDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BlueGreenDeploymentName a, BlueGreenDeploymentName b) => !(a == b);
    }

    public partial class BlueGreenDeployment
    {
        /// <summary>
        /// <see cref="gcsv::BlueGreenDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BlueGreenDeploymentName BlueGreenDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BlueGreenDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="SourceInstance"/> resource name property.
        /// </summary>
        public InstanceName SourceInstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(SourceInstance) ? null : InstanceName.Parse(SourceInstance, allowUnparsed: true);
            set => SourceInstance = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="SwitchoverTargetInstance"/> resource name
        /// property.
        /// </summary>
        public InstanceName SwitchoverTargetInstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(SwitchoverTargetInstance) ? null : InstanceName.Parse(SwitchoverTargetInstance, allowUnparsed: true);
            set => SwitchoverTargetInstance = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SourceTargetPairedNode
            {
                public partial class Types
                {
                    public partial class NodeInfo
                    {
                        /// <summary>
                        /// <see cref="InstanceName"/>-typed view over the <see cref="Instance"/> resource name
                        /// property.
                        /// </summary>
                        public InstanceName InstanceAsInstanceName
                        {
                            get => string.IsNullOrEmpty(Instance) ? null : InstanceName.Parse(Instance, allowUnparsed: true);
                            set => Instance = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class CreateBlueGreenDeploymentRequest
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

    public partial class GetBlueGreenDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcsv::BlueGreenDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BlueGreenDeploymentName BlueGreenDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BlueGreenDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SwitchoverBlueGreenDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcsv::BlueGreenDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BlueGreenDeploymentName BlueGreenDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BlueGreenDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBlueGreenDeploymentsRequest
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

    public partial class DeleteBlueGreenDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcsv::BlueGreenDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BlueGreenDeploymentName BlueGreenDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BlueGreenDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
