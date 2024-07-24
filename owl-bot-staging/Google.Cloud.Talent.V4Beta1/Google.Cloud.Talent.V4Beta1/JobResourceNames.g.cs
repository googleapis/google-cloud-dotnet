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
using gax = Google.Api.Gax;
using gctv = Google.Cloud.Talent.V4Beta1;
using sys = System;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Resource name for the <c>Job</c> resource.</summary>
    public sealed partial class JobName : gax::IResourceName, sys::IEquatable<JobName>
    {
        /// <summary>The possible contents of <see cref="JobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.</summary>
            ProjectTenantJob = 1,

            /// <summary>A resource name with pattern <c>projects/{project}/jobs/{job}</c>.</summary>
            ProjectJob = 2,
        }

        private static gax::PathTemplate s_projectTenantJob = new gax::PathTemplate("projects/{project}/tenants/{tenant}/jobs/{job}");

        private static gax::PathTemplate s_projectJob = new gax::PathTemplate("projects/{project}/jobs/{job}");

        /// <summary>Creates a <see cref="JobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="JobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static JobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new JobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="JobName"/> with the pattern <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobName"/> constructed from the provided ids.</returns>
        public static JobName FromProjectTenantJob(string projectId, string tenantId, string jobId) =>
            new JobName(ResourceNameType.ProjectTenantJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>Creates a <see cref="JobName"/> with the pattern <c>projects/{project}/jobs/{job}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobName"/> constructed from the provided ids.</returns>
        public static JobName FromProjectJob(string projectId, string jobId) =>
            new JobName(ResourceNameType.ProjectJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.
        /// </returns>
        public static string Format(string projectId, string tenantId, string jobId) =>
            FormatProjectTenantJob(projectId, tenantId, jobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>.
        /// </returns>
        public static string FormatProjectTenantJob(string projectId, string tenantId, string jobId) =>
            s_projectTenantJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern <c>projects/{project}/jobs/{job}</c>.
        /// </returns>
        public static string FormatProjectJob(string projectId, string jobId) =>
            s_projectJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>Parses the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/jobs/{job}</c></description></item>
        /// <item><description><c>projects/{project}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName) => Parse(jobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="JobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/jobs/{job}</c></description></item>
        /// <item><description><c>projects/{project}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName, bool allowUnparsed) =>
            TryParse(jobName, allowUnparsed, out JobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/jobs/{job}</c></description></item>
        /// <item><description><c>projects/{project}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, out JobName result) => TryParse(jobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/tenants/{tenant}/jobs/{job}</c></description></item>
        /// <item><description><c>projects/{project}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, bool allowUnparsed, out JobName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobName, nameof(jobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTenantJob.TryParseName(jobName, out resourceName))
            {
                result = FromProjectTenantJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectJob.TryParseName(jobName, out resourceName))
            {
                result = FromProjectJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(jobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private JobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobId = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobId = jobId;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="JobName"/> class from the component parts of pattern
        /// <c>projects/{project}/tenants/{tenant}/jobs/{job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        public JobName(string projectId, string tenantId, string jobId) : this(ResourceNameType.ProjectTenantJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)))
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
        /// The <c>Job</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string JobId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tenant</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string TenantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTenantJob: return s_projectTenantJob.Expand(ProjectId, TenantId, JobId);
                case ResourceNameType.ProjectJob: return s_projectJob.Expand(ProjectId, JobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as JobName);

        /// <inheritdoc/>
        public bool Equals(JobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(JobName a, JobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(JobName a, JobName b) => !(a == b);
    }

    public partial class Job
    {
        /// <summary>
        /// <see cref="gctv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CompanyName"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public CompanyName CompanyAsCompanyName
        {
            get => string.IsNullOrEmpty(Company) ? null : CompanyName.Parse(Company, allowUnparsed: true);
            set => Company = value?.ToString() ?? "";
        }
    }
}
