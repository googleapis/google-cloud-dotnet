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
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/jobs/{job}");

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
        /// <param name="jobId">The job ID. Must not be <c>null</c>.</param>
        public JobName(string projectId, string jobId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            JobId = gax::GaxPreconditions.CheckNotNull(jobId, nameof(jobId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The job ID. Never <c>null</c>.
        /// </summary>
        public string JobId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, JobId);

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
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/companies/{company}/profiles/{profile}");

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
        /// <param name="companyId">The company ID. Must not be <c>null</c>.</param>
        /// <param name="profileId">The profile ID. Must not be <c>null</c>.</param>
        public ProfileName(string projectId, string companyId, string profileId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            CompanyId = gax::GaxPreconditions.CheckNotNull(companyId, nameof(companyId));
            ProfileId = gax::GaxPreconditions.CheckNotNull(profileId, nameof(profileId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The company ID. Never <c>null</c>.
        /// </summary>
        public string CompanyId { get; }

        /// <summary>
        /// The profile ID. Never <c>null</c>.
        /// </summary>
        public string ProfileId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, CompanyId, ProfileId);

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



}