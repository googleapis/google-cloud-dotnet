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
    /// <summary>Resource name for the <c>PatchJob</c> resource.</summary>
    public sealed partial class PatchJobName : gax::IResourceName, sys::IEquatable<PatchJobName>
    {
        /// <summary>The possible contents of <see cref="PatchJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/patchJobs/{patch_job}</c>.</summary>
            ProjectPatchJob = 1,
        }

        private static gax::PathTemplate s_projectPatchJob = new gax::PathTemplate("projects/{project}/patchJobs/{patch_job}");

        /// <summary>Creates a <see cref="PatchJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PatchJobName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static PatchJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PatchJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PatchJobName"/> with the pattern <c>projects/{project}/patchJobs/{patch_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchJobId">The <c>PatchJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PatchJobName"/> constructed from the provided ids.</returns>
        public static PatchJobName FromProjectPatchJob(string projectId, string patchJobId) =>
            new PatchJobName(ResourceNameType.ProjectPatchJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), patchJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(patchJobId, nameof(patchJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PatchJobName"/> with pattern
        /// <c>projects/{project}/patchJobs/{patch_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchJobId">The <c>PatchJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PatchJobName"/> with pattern
        /// <c>projects/{project}/patchJobs/{patch_job}</c>.
        /// </returns>
        public static string Format(string projectId, string patchJobId) => FormatProjectPatchJob(projectId, patchJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PatchJobName"/> with pattern
        /// <c>projects/{project}/patchJobs/{patch_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchJobId">The <c>PatchJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PatchJobName"/> with pattern
        /// <c>projects/{project}/patchJobs/{patch_job}</c>.
        /// </returns>
        public static string FormatProjectPatchJob(string projectId, string patchJobId) =>
            s_projectPatchJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(patchJobId, nameof(patchJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="PatchJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchJobs/{patch_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="patchJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PatchJobName"/> if successful.</returns>
        public static PatchJobName Parse(string patchJobName) => Parse(patchJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PatchJobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchJobs/{patch_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="patchJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PatchJobName"/> if successful.</returns>
        public static PatchJobName Parse(string patchJobName, bool allowUnparsed) =>
            TryParse(patchJobName, allowUnparsed, out PatchJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PatchJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchJobs/{patch_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="patchJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PatchJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string patchJobName, out PatchJobName result) => TryParse(patchJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PatchJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/patchJobs/{patch_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="patchJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PatchJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string patchJobName, bool allowUnparsed, out PatchJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(patchJobName, nameof(patchJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectPatchJob.TryParseName(patchJobName, out resourceName))
            {
                result = FromProjectPatchJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(patchJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PatchJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string patchJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PatchJobId = patchJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PatchJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/patchJobs/{patch_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="patchJobId">The <c>PatchJob</c> ID. Must not be <c>null</c> or empty.</param>
        public PatchJobName(string projectId, string patchJobId) : this(ResourceNameType.ProjectPatchJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), patchJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(patchJobId, nameof(patchJobId)))
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
        /// The <c>PatchJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PatchJobId { get; }

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
                case ResourceNameType.ProjectPatchJob: return s_projectPatchJob.Expand(ProjectId, PatchJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PatchJobName);

        /// <inheritdoc/>
        public bool Equals(PatchJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PatchJobName a, PatchJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PatchJobName a, PatchJobName b) => !(a == b);
    }

    public partial class ExecutePatchJobRequest
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

    public partial class GetPatchJobRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchJobName PatchJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPatchJobInstanceDetailsRequest
    {
        /// <summary>
        /// <see cref="PatchJobName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PatchJobName ParentAsPatchJobName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PatchJobName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PatchJobInstanceDetails
    {
        /// <summary>
        /// <see cref="gcov::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPatchJobsRequest
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

    public partial class PatchJob
    {
        /// <summary>
        /// <see cref="gcov::PatchJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchJobName PatchJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PatchDeploymentName"/>-typed view over the <see cref="PatchDeployment"/> resource name property.
        /// </summary>
        public PatchDeploymentName PatchDeploymentAsPatchDeploymentName
        {
            get => string.IsNullOrEmpty(PatchDeployment) ? null : PatchDeploymentName.Parse(PatchDeployment, allowUnparsed: true);
            set => PatchDeployment = value?.ToString() ?? "";
        }
    }

    public partial class CancelPatchJobRequest
    {
        /// <summary>
        /// <see cref="gcov::PatchJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::PatchJobName PatchJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::PatchJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
