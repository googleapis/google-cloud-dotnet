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
using gaxres = Google.Api.Gax.ResourceNames;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>
    /// Resource name for the 'company' resource.
    /// </summary>
    public sealed partial class CompanyName : gax::IResourceName, sys::IEquatable<CompanyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/companies/{company}");

        /// <summary>
        /// Parses the given company resource name in string form into a new
        /// <see cref="CompanyName"/> instance.
        /// </summary>
        /// <param name="companyName">The company resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CompanyName"/> if successful.</returns>
        public static CompanyName Parse(string companyName)
        {
            gax::GaxPreconditions.CheckNotNull(companyName, nameof(companyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(companyName);
            return new CompanyName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given company resource name in string form into a new
        /// <see cref="CompanyName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="companyName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="companyName">The company resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CompanyName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string companyName, out CompanyName result)
        {
            gax::GaxPreconditions.CheckNotNull(companyName, nameof(companyName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(companyName, out resourceName))
            {
                result = new CompanyName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CompanyName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="companyId">The company ID. Must not be <c>null</c>.</param>
        public CompanyName(string projectId, string companyId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            CompanyId = gax::GaxPreconditions.CheckNotNull(companyId, nameof(companyId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The company ID. Never <c>null</c>.
        /// </summary>
        public string CompanyId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, CompanyId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CompanyName);

        /// <inheritdoc />
        public bool Equals(CompanyName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CompanyName a, CompanyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CompanyName a, CompanyName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'job' resource.
    /// </summary>
    public sealed partial class JobName : gax::IResourceName, sys::IEquatable<JobName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/jobs/{jobs}");

        /// <summary>
        /// Parses the given job resource name in string form into a new
        /// <see cref="JobName"/> instance.
        /// </summary>
        /// <param name="jobName">The job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName)
        {
            gax::GaxPreconditions.CheckNotNull(jobName, nameof(jobName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(jobName);
            return new JobName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given job resource name in string form into a new
        /// <see cref="JobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="jobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="jobName">The job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="JobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, out JobName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobName, nameof(jobName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(jobName, out resourceName))
            {
                result = new JobName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="JobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="jobsId">The jobs ID. Must not be <c>null</c>.</param>
        public JobName(string projectId, string jobsId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            JobsId = gax::GaxPreconditions.CheckNotNull(jobsId, nameof(jobsId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The jobs ID. Never <c>null</c>.
        /// </summary>
        public string JobsId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, JobsId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as JobName);

        /// <inheritdoc />
        public bool Equals(JobName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(JobName a, JobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(JobName a, JobName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'profile' resource.
    /// </summary>
    public sealed partial class ProfileName : gax::IResourceName, sys::IEquatable<ProfileName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/tenants/{tenant}/profiles/{profile}");

        /// <summary>
        /// Parses the given profile resource name in string form into a new
        /// <see cref="ProfileName"/> instance.
        /// </summary>
        /// <param name="profileName">The profile resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProfileName"/> if successful.</returns>
        public static ProfileName Parse(string profileName)
        {
            gax::GaxPreconditions.CheckNotNull(profileName, nameof(profileName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(profileName);
            return new ProfileName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given profile resource name in string form into a new
        /// <see cref="ProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="profileName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="profileName">The profile resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProfileName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string profileName, out ProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(profileName, nameof(profileName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(profileName, out resourceName))
            {
                result = new ProfileName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProfileName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="tenantId">The tenant ID. Must not be <c>null</c>.</param>
        /// <param name="profileId">The profile ID. Must not be <c>null</c>.</param>
        public ProfileName(string projectId, string tenantId, string profileId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TenantId = gax::GaxPreconditions.CheckNotNull(tenantId, nameof(tenantId));
            ProfileId = gax::GaxPreconditions.CheckNotNull(profileId, nameof(profileId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The tenant ID. Never <c>null</c>.
        /// </summary>
        public string TenantId { get; }

        /// <summary>
        /// The profile ID. Never <c>null</c>.
        /// </summary>
        public string ProfileId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TenantId, ProfileId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProfileName);

        /// <inheritdoc />
        public bool Equals(ProfileName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProfileName a, ProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProfileName a, ProfileName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'tenant' resource.
    /// </summary>
    public sealed partial class TenantName : gax::IResourceName, sys::IEquatable<TenantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/tenants/{tenant}");

        /// <summary>
        /// Parses the given tenant resource name in string form into a new
        /// <see cref="TenantName"/> instance.
        /// </summary>
        /// <param name="tenantName">The tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TenantName"/> if successful.</returns>
        public static TenantName Parse(string tenantName)
        {
            gax::GaxPreconditions.CheckNotNull(tenantName, nameof(tenantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(tenantName);
            return new TenantName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given tenant resource name in string form into a new
        /// <see cref="TenantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="tenantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="tenantName">The tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TenantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tenantName, out TenantName result)
        {
            gax::GaxPreconditions.CheckNotNull(tenantName, nameof(tenantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(tenantName, out resourceName))
            {
                result = new TenantName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TenantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="tenantId">The tenant ID. Must not be <c>null</c>.</param>
        public TenantName(string projectId, string tenantId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TenantId = gax::GaxPreconditions.CheckNotNull(tenantId, nameof(tenantId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The tenant ID. Never <c>null</c>.
        /// </summary>
        public string TenantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TenantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TenantName);

        /// <inheritdoc />
        public bool Equals(TenantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TenantName a, TenantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TenantName a, TenantName b) => !(a == b);
    }


    public partial class BatchDeleteJobsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Company
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyName CompanyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CompleteQueryRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gaxres::ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateClientEventRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateCompanyRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateJobRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateProfileRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName ParentAsTenantName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTenantRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteCompanyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyName CompanyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobName JobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteProfileRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ProfileName ProfileName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ProfileName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTenantRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName TenantName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetCompanyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyName CompanyName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobName JobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetProfileRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ProfileName ProfileName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ProfileName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTenantRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName TenantName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Job
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobName JobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListCompaniesRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListJobsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListProfilesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName ParentAsTenantName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTenantsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ParseResumeRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Profile
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ProfileName ProfileName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ProfileName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SearchJobsRequest
    {
        /// <summary>
        /// <see cref="gaxres::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SearchProfilesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName ParentAsTenantName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Tenant
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantName TenantName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.TenantName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}