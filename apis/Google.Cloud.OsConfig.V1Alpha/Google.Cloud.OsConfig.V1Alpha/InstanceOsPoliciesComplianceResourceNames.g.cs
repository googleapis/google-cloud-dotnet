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
using gcov = Google.Cloud.OsConfig.V1Alpha;
using sys = System;

namespace Google.Cloud.OsConfig.V1Alpha
{
    /// <summary>Resource name for the <c>InstanceOSPoliciesCompliance</c> resource.</summary>
    public sealed partial class InstanceOSPoliciesComplianceName : gax::IResourceName, sys::IEquatable<InstanceOSPoliciesComplianceName>
    {
        /// <summary>The possible contents of <see cref="InstanceOSPoliciesComplianceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
            /// </summary>
            ProjectLocationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}");

        /// <summary>
        /// Creates a <see cref="InstanceOSPoliciesComplianceName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceOSPoliciesComplianceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceOSPoliciesComplianceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceOSPoliciesComplianceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceOSPoliciesComplianceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceOSPoliciesComplianceName"/> constructed from the provided ids.
        /// </returns>
        public static InstanceOSPoliciesComplianceName FromProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            new InstanceOSPoliciesComplianceName(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceOSPoliciesComplianceName"/> with
        /// pattern <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceOSPoliciesComplianceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            FormatProjectLocationInstance(projectId, locationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceOSPoliciesComplianceName"/> with
        /// pattern <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceOSPoliciesComplianceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            s_projectLocationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceOSPoliciesComplianceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceOSPoliciesComplianceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="InstanceOSPoliciesComplianceName"/> if successful.</returns>
        public static InstanceOSPoliciesComplianceName Parse(string instanceOSPoliciesComplianceName) =>
            Parse(instanceOSPoliciesComplianceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceOSPoliciesComplianceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceOSPoliciesComplianceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceOSPoliciesComplianceName"/> if successful.</returns>
        public static InstanceOSPoliciesComplianceName Parse(string instanceOSPoliciesComplianceName, bool allowUnparsed) =>
            TryParse(instanceOSPoliciesComplianceName, allowUnparsed, out InstanceOSPoliciesComplianceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceOSPoliciesComplianceName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="instanceOSPoliciesComplianceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceOSPoliciesComplianceName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceOSPoliciesComplianceName, out InstanceOSPoliciesComplianceName result) =>
            TryParse(instanceOSPoliciesComplianceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceOSPoliciesComplianceName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceOSPoliciesComplianceName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceOSPoliciesComplianceName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceOSPoliciesComplianceName, bool allowUnparsed, out InstanceOSPoliciesComplianceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceOSPoliciesComplianceName, nameof(instanceOSPoliciesComplianceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstance.TryParseName(instanceOSPoliciesComplianceName, out resourceName))
            {
                result = FromProjectLocationInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceOSPoliciesComplianceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceOSPoliciesComplianceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceOSPoliciesComplianceName"/> class from the component parts
        /// of pattern <c>projects/{project}/locations/{location}/instanceOSPoliciesCompliances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceOSPoliciesComplianceName(string projectId, string locationId, string instanceId) : this(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
                case ResourceNameType.ProjectLocationInstance: return s_projectLocationInstance.Expand(ProjectId, LocationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceOSPoliciesComplianceName);

        /// <inheritdoc/>
        public bool Equals(InstanceOSPoliciesComplianceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceOSPoliciesComplianceName a, InstanceOSPoliciesComplianceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceOSPoliciesComplianceName a, InstanceOSPoliciesComplianceName b) => !(a == b);
    }

    public partial class InstanceOSPoliciesCompliance
    {
        /// <summary>
        /// <see cref="gcov::InstanceOSPoliciesComplianceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcov::InstanceOSPoliciesComplianceName InstanceOSPoliciesComplianceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::InstanceOSPoliciesComplianceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class OSPolicyCompliance
            {
                /// <summary>
                /// <see cref="OSPolicyAssignmentName"/>-typed view over the <see cref="OsPolicyAssignment"/> resource
                /// name property.
                /// </summary>
                [sys::ObsoleteAttribute]
                public OSPolicyAssignmentName OsPolicyAssignmentAsOSPolicyAssignmentName
                {
                    get => string.IsNullOrEmpty(OsPolicyAssignment) ? null : OSPolicyAssignmentName.Parse(OsPolicyAssignment, allowUnparsed: true);
                    set => OsPolicyAssignment = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class GetInstanceOSPoliciesComplianceRequest
    {
        /// <summary>
        /// <see cref="gcov::InstanceOSPoliciesComplianceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcov::InstanceOSPoliciesComplianceName InstanceOSPoliciesComplianceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::InstanceOSPoliciesComplianceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstanceOSPoliciesCompliancesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
