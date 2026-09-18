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
using gax = Google.Api.Gax;
using gcbv = Google.Cloud.BackupDR.V1Beta;
using sys = System;

namespace Google.Cloud.BackupDR.V1Beta
{
    /// <summary>Resource name for the <c>BindingMatchingResource</c> resource.</summary>
    public sealed partial class BindingMatchingResourceName : gax::IResourceName, sys::IEquatable<BindingMatchingResourceName>
    {
        /// <summary>The possible contents of <see cref="BindingMatchingResourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
            /// .
            /// </summary>
            ProjectLocationAutoProtectionPolicyBindingMatchingResource = 1,
        }

        private static gax::PathTemplate s_projectLocationAutoProtectionPolicyBindingMatchingResource = new gax::PathTemplate("projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}");

        /// <summary>Creates a <see cref="BindingMatchingResourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BindingMatchingResourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BindingMatchingResourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BindingMatchingResourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BindingMatchingResourceName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="matchingResourceId">The <c>MatchingResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="BindingMatchingResourceName"/> constructed from the provided ids.
        /// </returns>
        public static BindingMatchingResourceName FromProjectLocationAutoProtectionPolicyBindingMatchingResource(string projectId, string locationId, string autoProtectionPolicyId, string bindingId, string matchingResourceId) =>
            new BindingMatchingResourceName(ResourceNameType.ProjectLocationAutoProtectionPolicyBindingMatchingResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoProtectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), bindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)), matchingResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(matchingResourceId, nameof(matchingResourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BindingMatchingResourceName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="matchingResourceId">The <c>MatchingResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BindingMatchingResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string autoProtectionPolicyId, string bindingId, string matchingResourceId) =>
            FormatProjectLocationAutoProtectionPolicyBindingMatchingResource(projectId, locationId, autoProtectionPolicyId, bindingId, matchingResourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BindingMatchingResourceName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="matchingResourceId">The <c>MatchingResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BindingMatchingResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAutoProtectionPolicyBindingMatchingResource(string projectId, string locationId, string autoProtectionPolicyId, string bindingId, string matchingResourceId) =>
            s_projectLocationAutoProtectionPolicyBindingMatchingResource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(matchingResourceId, nameof(matchingResourceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BindingMatchingResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="bindingMatchingResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BindingMatchingResourceName"/> if successful.</returns>
        public static BindingMatchingResourceName Parse(string bindingMatchingResourceName) =>
            Parse(bindingMatchingResourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BindingMatchingResourceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bindingMatchingResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BindingMatchingResourceName"/> if successful.</returns>
        public static BindingMatchingResourceName Parse(string bindingMatchingResourceName, bool allowUnparsed) =>
            TryParse(bindingMatchingResourceName, allowUnparsed, out BindingMatchingResourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BindingMatchingResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="bindingMatchingResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BindingMatchingResourceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bindingMatchingResourceName, out BindingMatchingResourceName result) =>
            TryParse(bindingMatchingResourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BindingMatchingResourceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bindingMatchingResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BindingMatchingResourceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bindingMatchingResourceName, bool allowUnparsed, out BindingMatchingResourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(bindingMatchingResourceName, nameof(bindingMatchingResourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAutoProtectionPolicyBindingMatchingResource.TryParseName(bindingMatchingResourceName, out resourceName))
            {
                result = FromProjectLocationAutoProtectionPolicyBindingMatchingResource(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bindingMatchingResourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BindingMatchingResourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string autoProtectionPolicyId = null, string bindingId = null, string locationId = null, string matchingResourceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutoProtectionPolicyId = autoProtectionPolicyId;
            BindingId = bindingId;
            LocationId = locationId;
            MatchingResourceId = matchingResourceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BindingMatchingResourceName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}/matchingResources/{matching_resource}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="matchingResourceId">The <c>MatchingResource</c> ID. Must not be <c>null</c> or empty.</param>
        public BindingMatchingResourceName(string projectId, string locationId, string autoProtectionPolicyId, string bindingId, string matchingResourceId) : this(ResourceNameType.ProjectLocationAutoProtectionPolicyBindingMatchingResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoProtectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), bindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)), matchingResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(matchingResourceId, nameof(matchingResourceId)))
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
        /// The <c>AutoProtectionPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AutoProtectionPolicyId { get; }

        /// <summary>
        /// The <c>Binding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BindingId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MatchingResource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MatchingResourceId { get; }

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
                case ResourceNameType.ProjectLocationAutoProtectionPolicyBindingMatchingResource: return s_projectLocationAutoProtectionPolicyBindingMatchingResource.Expand(ProjectId, LocationId, AutoProtectionPolicyId, BindingId, MatchingResourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BindingMatchingResourceName);

        /// <inheritdoc/>
        public bool Equals(BindingMatchingResourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BindingMatchingResourceName a, BindingMatchingResourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BindingMatchingResourceName a, BindingMatchingResourceName b) => !(a == b);
    }

    public partial class GetBindingMatchingResourceRequest
    {
        /// <summary>
        /// <see cref="gcbv::BindingMatchingResourceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::BindingMatchingResourceName BindingMatchingResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BindingMatchingResourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBindingMatchingResourcesRequest
    {
        /// <summary>
        /// <see cref="AutoProtectionPolicyBindingName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        public AutoProtectionPolicyBindingName ParentAsAutoProtectionPolicyBindingName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AutoProtectionPolicyBindingName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BindingMatchingResource
    {
        /// <summary>
        /// <see cref="gcbv::BindingMatchingResourceName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::BindingMatchingResourceName BindingMatchingResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BindingMatchingResourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AutoProtectionDetails
    {
        /// <summary>
        /// <see cref="BackupPlanAssociationName"/>-typed view over the <see cref="BackupPlanAssociation"/> resource
        /// name property.
        /// </summary>
        public BackupPlanAssociationName BackupPlanAssociationAsBackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(BackupPlanAssociation) ? null : BackupPlanAssociationName.Parse(BackupPlanAssociation, allowUnparsed: true);
            set => BackupPlanAssociation = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataSourceName"/>-typed view over the <see cref="DataSource"/> resource name property.
        /// </summary>
        public DataSourceName DataSourceAsDataSourceName
        {
            get => string.IsNullOrEmpty(DataSource) ? null : DataSourceName.Parse(DataSource, allowUnparsed: true);
            set => DataSource = value?.ToString() ?? "";
        }
    }
}
