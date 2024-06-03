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
using gcov = Google.Cloud.OsConfig.V1;
using sys = System;

namespace Google.Cloud.OsConfig.V1
{
    /// <summary>Resource name for the <c>PatchDeployment</c> resource.</summary>
    public sealed partial class PatchDeploymentName : gax::IResourceName, sys::IEquatable<PatchDeploymentName>
    {
        /// <summary>The possible contents of <see cref="PatchDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
            /// </summary>
            ProjectPatchDeployment = 1,
        }

        private static gax::PathTemplate s_projectPatchDeployment = new gax::PathTemplate("projects/{project}/patchDeployments/{patch_deployment}");

        /// <summary>Creates a <see cref="PatchDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PatchDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PatchDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PatchDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PatchDeploymentName"/> with the pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchDeploymentId">The <c>PatchDeployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PatchDeploymentName"/> constructed from the provided ids.</returns>
        public static PatchDeploymentName FromProjectPatchDeployment(string projectId, string patchDeploymentId) =>
            new PatchDeploymentName(ResourceNameType.ProjectPatchDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), patchDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PatchDeploymentName"/> with pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchDeploymentId">The <c>PatchDeployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PatchDeploymentName"/> with pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
        /// </returns>
        public static string Format(string projectId, string patchDeploymentId) =>
            FormatProjectPatchDeployment(projectId, patchDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PatchDeploymentName"/> with pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchDeploymentId">The <c>PatchDeployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PatchDeploymentName"/> with pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>.
        /// </returns>
        public static string FormatProjectPatchDeployment(string projectId, string patchDeploymentId) =>
            s_projectPatchDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PatchDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchDeployments/{patch_deployment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="patchDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PatchDeploymentName"/> if successful.</returns>
        public static PatchDeploymentName Parse(string patchDeploymentName) => Parse(patchDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PatchDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchDeployments/{patch_deployment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="patchDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PatchDeploymentName"/> if successful.</returns>
        public static PatchDeploymentName Parse(string patchDeploymentName, bool allowUnparsed) =>
            TryParse(patchDeploymentName, allowUnparsed, out PatchDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PatchDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchDeployments/{patch_deployment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="patchDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PatchDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string patchDeploymentName, out PatchDeploymentName result) =>
            TryParse(patchDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PatchDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchDeployments/{patch_deployment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="patchDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PatchDeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string patchDeploymentName, bool allowUnparsed, out PatchDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(patchDeploymentName, nameof(patchDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectPatchDeployment.TryParseName(patchDeploymentName, out resourceName))
            {
                result = FromProjectPatchDeployment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(patchDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PatchDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string patchDeploymentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PatchDeploymentId = patchDeploymentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PatchDeploymentName"/> class from the component parts of pattern
        /// <c>projects/{project}/patchDeployments/{patch_deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchDeploymentId">The <c>PatchDeployment</c> ID. Must not be <c>null</c> or empty.</param>
        public PatchDeploymentName(string projectId, string patchDeploymentId) : this(ResourceNameType.ProjectPatchDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), patchDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)))
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
        /// The <c>PatchDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PatchDeploymentId { get; }

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
                case ResourceNameType.ProjectPatchDeployment: return s_projectPatchDeployment.Expand(ProjectId, PatchDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PatchDeploymentName);

        /// <inheritdoc/>
        public bool Equals(PatchDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PatchDeploymentName a, PatchDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PatchDeploymentName a, PatchDeploymentName b) => !(a == b);
    }

    public partial class PatchDeployment
    {
        /// <summary>
        /// <see cref="gcov::PatchDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchDeploymentName PatchDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePatchDeploymentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPatchDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchDeploymentName PatchDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPatchDeploymentsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePatchDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchDeploymentName PatchDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PausePatchDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchDeploymentName PatchDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumePatchDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchDeploymentName PatchDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
