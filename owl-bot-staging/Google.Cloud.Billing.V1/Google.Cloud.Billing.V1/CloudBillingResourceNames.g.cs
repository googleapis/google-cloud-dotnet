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
using gcbv = Google.Cloud.Billing.V1;
using sys = System;

namespace Google.Cloud.Billing.V1
{
    /// <summary>Resource name for the <c>ProjectBillingInfo</c> resource.</summary>
    public sealed partial class ProjectBillingInfoName : gax::IResourceName, sys::IEquatable<ProjectBillingInfoName>
    {
        /// <summary>The possible contents of <see cref="ProjectBillingInfoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/billingInfo</c>.</summary>
            Project = 1,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}/billingInfo");

        /// <summary>Creates a <see cref="ProjectBillingInfoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProjectBillingInfoName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProjectBillingInfoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProjectBillingInfoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProjectBillingInfoName"/> with the pattern <c>projects/{project}/billingInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProjectBillingInfoName"/> constructed from the provided ids.</returns>
        public static ProjectBillingInfoName FromProject(string projectId) =>
            new ProjectBillingInfoName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProjectBillingInfoName"/> with pattern
        /// <c>projects/{project}/billingInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProjectBillingInfoName"/> with pattern
        /// <c>projects/{project}/billingInfo</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProjectBillingInfoName"/> with pattern
        /// <c>projects/{project}/billingInfo</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProjectBillingInfoName"/> with pattern
        /// <c>projects/{project}/billingInfo</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProjectBillingInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/billingInfo</c></description></item></list>
        /// </remarks>
        /// <param name="projectBillingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectBillingInfoName"/> if successful.</returns>
        public static ProjectBillingInfoName Parse(string projectBillingInfoName) => Parse(projectBillingInfoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProjectBillingInfoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/billingInfo</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="projectBillingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProjectBillingInfoName"/> if successful.</returns>
        public static ProjectBillingInfoName Parse(string projectBillingInfoName, bool allowUnparsed) =>
            TryParse(projectBillingInfoName, allowUnparsed, out ProjectBillingInfoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProjectBillingInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/billingInfo</c></description></item></list>
        /// </remarks>
        /// <param name="projectBillingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProjectBillingInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectBillingInfoName, out ProjectBillingInfoName result) =>
            TryParse(projectBillingInfoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProjectBillingInfoName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/billingInfo</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="projectBillingInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProjectBillingInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectBillingInfoName, bool allowUnparsed, out ProjectBillingInfoName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectBillingInfoName, nameof(projectBillingInfoName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(projectBillingInfoName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(projectBillingInfoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProjectBillingInfoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProjectBillingInfoName"/> class from the component parts of
        /// pattern <c>projects/{project}/billingInfo</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public ProjectBillingInfoName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProjectBillingInfoName);

        /// <inheritdoc/>
        public bool Equals(ProjectBillingInfoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProjectBillingInfoName a, ProjectBillingInfoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProjectBillingInfoName a, ProjectBillingInfoName b) => !(a == b);
    }

    public partial class BillingAccount
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProjectBillingInfo
    {
        /// <summary>
        /// <see cref="gcbv::ProjectBillingInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ProjectBillingInfoName ProjectBillingInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ProjectBillingInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBillingAccountRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateBillingAccountRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProjectBillingInfoRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProjectBillingInfoRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MoveBillingAccountRequest
    {
        /// <summary>
        /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::BillingAccountName BillingAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::BillingAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="DestinationParent"/> resource name
        /// property.
        /// </summary>
        public gagr::OrganizationName DestinationParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(DestinationParent) ? null : gagr::OrganizationName.Parse(DestinationParent, allowUnparsed: true);
            set => DestinationParent = value?.ToString() ?? "";
        }
    }
}
