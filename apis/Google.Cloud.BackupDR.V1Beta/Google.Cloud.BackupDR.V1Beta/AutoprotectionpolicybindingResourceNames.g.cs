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
    /// <summary>Resource name for the <c>AutoProtectionPolicyBinding</c> resource.</summary>
    public sealed partial class AutoProtectionPolicyBindingName : gax::IResourceName, sys::IEquatable<AutoProtectionPolicyBindingName>
    {
        /// <summary>The possible contents of <see cref="AutoProtectionPolicyBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
            /// .
            /// </summary>
            ProjectLocationAutoProtectionPolicyBinding = 1,
        }

        private static gax::PathTemplate s_projectLocationAutoProtectionPolicyBinding = new gax::PathTemplate("projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}");

        /// <summary>
        /// Creates a <see cref="AutoProtectionPolicyBindingName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutoProtectionPolicyBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutoProtectionPolicyBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutoProtectionPolicyBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutoProtectionPolicyBindingName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AutoProtectionPolicyBindingName"/> constructed from the provided ids.
        /// </returns>
        public static AutoProtectionPolicyBindingName FromProjectLocationAutoProtectionPolicyBinding(string projectId, string locationId, string autoProtectionPolicyId, string bindingId) =>
            new AutoProtectionPolicyBindingName(ResourceNameType.ProjectLocationAutoProtectionPolicyBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoProtectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), bindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoProtectionPolicyBindingName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoProtectionPolicyBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string autoProtectionPolicyId, string bindingId) =>
            FormatProjectLocationAutoProtectionPolicyBinding(projectId, locationId, autoProtectionPolicyId, bindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoProtectionPolicyBindingName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoProtectionPolicyBindingName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAutoProtectionPolicyBinding(string projectId, string locationId, string autoProtectionPolicyId, string bindingId) =>
            s_projectLocationAutoProtectionPolicyBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoProtectionPolicyBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoProtectionPolicyBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AutoProtectionPolicyBindingName"/> if successful.</returns>
        public static AutoProtectionPolicyBindingName Parse(string autoProtectionPolicyBindingName) =>
            Parse(autoProtectionPolicyBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoProtectionPolicyBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoProtectionPolicyBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutoProtectionPolicyBindingName"/> if successful.</returns>
        public static AutoProtectionPolicyBindingName Parse(string autoProtectionPolicyBindingName, bool allowUnparsed) =>
            TryParse(autoProtectionPolicyBindingName, allowUnparsed, out AutoProtectionPolicyBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoProtectionPolicyBindingName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoProtectionPolicyBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoProtectionPolicyBindingName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoProtectionPolicyBindingName, out AutoProtectionPolicyBindingName result) =>
            TryParse(autoProtectionPolicyBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoProtectionPolicyBindingName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoProtectionPolicyBindingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoProtectionPolicyBindingName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoProtectionPolicyBindingName, bool allowUnparsed, out AutoProtectionPolicyBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(autoProtectionPolicyBindingName, nameof(autoProtectionPolicyBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAutoProtectionPolicyBinding.TryParseName(autoProtectionPolicyBindingName, out resourceName))
            {
                result = FromProjectLocationAutoProtectionPolicyBinding(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(autoProtectionPolicyBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutoProtectionPolicyBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string autoProtectionPolicyId = null, string bindingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutoProtectionPolicyId = autoProtectionPolicyId;
            BindingId = bindingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutoProtectionPolicyBindingName"/> class from the component parts
        /// of pattern
        /// <c>
        /// projects/{project}/locations/{location}/autoProtectionPolicies/{auto_protection_policy}/bindings/{binding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoProtectionPolicyId">
        /// The <c>AutoProtectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="bindingId">The <c>Binding</c> ID. Must not be <c>null</c> or empty.</param>
        public AutoProtectionPolicyBindingName(string projectId, string locationId, string autoProtectionPolicyId, string bindingId) : this(ResourceNameType.ProjectLocationAutoProtectionPolicyBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoProtectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoProtectionPolicyId, nameof(autoProtectionPolicyId)), bindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(bindingId, nameof(bindingId)))
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
                case ResourceNameType.ProjectLocationAutoProtectionPolicyBinding: return s_projectLocationAutoProtectionPolicyBinding.Expand(ProjectId, LocationId, AutoProtectionPolicyId, BindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutoProtectionPolicyBindingName);

        /// <inheritdoc/>
        public bool Equals(AutoProtectionPolicyBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AutoProtectionPolicyBindingName a, AutoProtectionPolicyBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AutoProtectionPolicyBindingName a, AutoProtectionPolicyBindingName b) => !(a == b);
    }

    public partial class AutoProtectionPolicyBinding
    {
        /// <summary>
        /// <see cref="gcbv::AutoProtectionPolicyBindingName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::AutoProtectionPolicyBindingName AutoProtectionPolicyBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AutoProtectionPolicyBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Scope"/> resource name property.
        /// </summary>
        public gax::IResourceName ScopeAsResourceName
        {
            get => string.IsNullOrEmpty(Scope) ? null : gax::UnparsedResourceName.Parse(Scope);
            set => Scope = value?.ToString() ?? "";
        }
    }

    public partial class CreateAutoProtectionPolicyBindingRequest
    {
        /// <summary>
        /// <see cref="AutoProtectionPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AutoProtectionPolicyName ParentAsAutoProtectionPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AutoProtectionPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAutoProtectionPolicyBindingRequest
    {
        /// <summary>
        /// <see cref="gcbv::AutoProtectionPolicyBindingName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::AutoProtectionPolicyBindingName AutoProtectionPolicyBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AutoProtectionPolicyBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAutoProtectionPolicyBindingsRequest
    {
        /// <summary>
        /// <see cref="AutoProtectionPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AutoProtectionPolicyName ParentAsAutoProtectionPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AutoProtectionPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class InitiateDeleteAutoProtectionPolicyBindingRequest
    {
        /// <summary>
        /// <see cref="gcbv::AutoProtectionPolicyBindingName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcbv::AutoProtectionPolicyBindingName AutoProtectionPolicyBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AutoProtectionPolicyBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
