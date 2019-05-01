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
    /// Resource name for the 'application' resource.
    /// </summary>
    public sealed partial class ApplicationName : gax::IResourceName, sys::IEquatable<ApplicationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/tenants/{tenant}/profiles/{profile}/applications/{application}");

        /// <summary>
        /// Parses the given application resource name in string form into a new
        /// <see cref="ApplicationName"/> instance.
        /// </summary>
        /// <param name="applicationName">The application resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ApplicationName"/> if successful.</returns>
        public static ApplicationName Parse(string applicationName)
        {
            gax::GaxPreconditions.CheckNotNull(applicationName, nameof(applicationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(applicationName);
            return new ApplicationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given application resource name in string form into a new
        /// <see cref="ApplicationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="applicationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="applicationName">The application resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ApplicationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string applicationName, out ApplicationName result)
        {
            gax::GaxPreconditions.CheckNotNull(applicationName, nameof(applicationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(applicationName, out resourceName))
            {
                result = new ApplicationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ApplicationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="tenantId">The tenant ID. Must not be <c>null</c>.</param>
        /// <param name="profileId">The profile ID. Must not be <c>null</c>.</param>
        /// <param name="applicationId">The application ID. Must not be <c>null</c>.</param>
        public ApplicationName(string projectId, string tenantId, string profileId, string applicationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TenantId = gax::GaxPreconditions.CheckNotNull(tenantId, nameof(tenantId));
            ProfileId = gax::GaxPreconditions.CheckNotNull(profileId, nameof(profileId));
            ApplicationId = gax::GaxPreconditions.CheckNotNull(applicationId, nameof(applicationId));
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

        /// <summary>
        /// The application ID. Never <c>null</c>.
        /// </summary>
        public string ApplicationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TenantId, ProfileId, ApplicationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ApplicationName);

        /// <inheritdoc />
        public bool Equals(ApplicationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ApplicationName a, ApplicationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ApplicationName a, ApplicationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'company' resource.
    /// </summary>
    public sealed partial class CompanyName : gax::IResourceName, sys::IEquatable<CompanyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/tenants/{tenant}/companies/{company}");

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
            return new CompanyName(resourceName[0], resourceName[1], resourceName[2]);
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
                result = new CompanyName(resourceName[0], resourceName[1], resourceName[2]);
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
        /// <param name="tenantId">The tenant ID. Must not be <c>null</c>.</param>
        /// <param name="companyId">The company ID. Must not be <c>null</c>.</param>
        public CompanyName(string projectId, string tenantId, string companyId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TenantId = gax::GaxPreconditions.CheckNotNull(tenantId, nameof(tenantId));
            CompanyId = gax::GaxPreconditions.CheckNotNull(companyId, nameof(companyId));
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
        /// The company ID. Never <c>null</c>.
        /// </summary>
        public string CompanyId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TenantId, CompanyId);

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
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>CompanyName: A resource of type 'company'.</description></item>
    /// <item><description>CompanyWithoutTenantName: A resource of type 'company_without_tenant'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class CompanyNameOneof : gax::IResourceName, sys::IEquatable<CompanyNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="CompanyNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'company'.
            /// </summary>
            CompanyName = 1,

            /// <summary>
            /// A resource of type 'company_without_tenant'.
            /// </summary>
            CompanyWithoutTenantName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="CompanyNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>CompanyName: A resource of type 'company'.</description></item>
        /// <item><description>CompanyWithoutTenantName: A resource of type 'company_without_tenant'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="CompanyNameOneof"/> if successful.</returns>
        public static CompanyNameOneof Parse(string name, bool allowUnknown)
        {
            CompanyNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="CompanyNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>CompanyName: A resource of type 'company'.</description></item>
        /// <item><description>CompanyWithoutTenantName: A resource of type 'company_without_tenant'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CompanyNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out CompanyNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            CompanyName companyName;
            if (CompanyName.TryParse(name, out companyName))
            {
                result = new CompanyNameOneof(OneofType.CompanyName, companyName);
                return true;
            }
            CompanyWithoutTenantName companyWithoutTenantName;
            if (CompanyWithoutTenantName.TryParse(name, out companyWithoutTenantName))
            {
                result = new CompanyNameOneof(OneofType.CompanyWithoutTenantName, companyWithoutTenantName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new CompanyNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="CompanyNameOneof"/> from the provided <see cref="CompanyName"/>
        /// </summary>
        /// <param name="companyName">The <see cref="CompanyName"/> to be contained within
        /// the returned <see cref="CompanyNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="CompanyNameOneof"/>, containing <paramref name="companyName"/>.</returns>
        public static CompanyNameOneof From(CompanyName companyName) => new CompanyNameOneof(OneofType.CompanyName, companyName);

        /// <summary>
        /// Construct a new instance of <see cref="CompanyNameOneof"/> from the provided <see cref="CompanyWithoutTenantName"/>
        /// </summary>
        /// <param name="companyWithoutTenantName">The <see cref="CompanyWithoutTenantName"/> to be contained within
        /// the returned <see cref="CompanyNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="CompanyNameOneof"/>, containing <paramref name="companyWithoutTenantName"/>.</returns>
        public static CompanyNameOneof From(CompanyWithoutTenantName companyWithoutTenantName) => new CompanyNameOneof(OneofType.CompanyWithoutTenantName, companyWithoutTenantName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.CompanyName: return name is CompanyName;
                case OneofType.CompanyWithoutTenantName: return name is CompanyWithoutTenantName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CompanyNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public CompanyNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="CompanyName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="CompanyName"/>.
        /// </remarks>
        public CompanyName CompanyName => CheckAndReturn<CompanyName>(OneofType.CompanyName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="CompanyWithoutTenantName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="CompanyWithoutTenantName"/>.
        /// </remarks>
        public CompanyWithoutTenantName CompanyWithoutTenantName => CheckAndReturn<CompanyWithoutTenantName>(OneofType.CompanyWithoutTenantName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CompanyNameOneof);

        /// <inheritdoc />
        public bool Equals(CompanyNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CompanyNameOneof a, CompanyNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CompanyNameOneof a, CompanyNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'company_without_tenant' resource.
    /// </summary>
    public sealed partial class CompanyWithoutTenantName : gax::IResourceName, sys::IEquatable<CompanyWithoutTenantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/companies/{company}");

        /// <summary>
        /// Parses the given company_without_tenant resource name in string form into a new
        /// <see cref="CompanyWithoutTenantName"/> instance.
        /// </summary>
        /// <param name="companyWithoutTenantName">The company_without_tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CompanyWithoutTenantName"/> if successful.</returns>
        public static CompanyWithoutTenantName Parse(string companyWithoutTenantName)
        {
            gax::GaxPreconditions.CheckNotNull(companyWithoutTenantName, nameof(companyWithoutTenantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(companyWithoutTenantName);
            return new CompanyWithoutTenantName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given company_without_tenant resource name in string form into a new
        /// <see cref="CompanyWithoutTenantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="companyWithoutTenantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="companyWithoutTenantName">The company_without_tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CompanyWithoutTenantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string companyWithoutTenantName, out CompanyWithoutTenantName result)
        {
            gax::GaxPreconditions.CheckNotNull(companyWithoutTenantName, nameof(companyWithoutTenantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(companyWithoutTenantName, out resourceName))
            {
                result = new CompanyWithoutTenantName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CompanyWithoutTenantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="companyId">The company ID. Must not be <c>null</c>.</param>
        public CompanyWithoutTenantName(string projectId, string companyId)
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
        public override bool Equals(object obj) => Equals(obj as CompanyWithoutTenantName);

        /// <inheritdoc />
        public bool Equals(CompanyWithoutTenantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CompanyWithoutTenantName a, CompanyWithoutTenantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CompanyWithoutTenantName a, CompanyWithoutTenantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'job' resource.
    /// </summary>
    public sealed partial class JobName : gax::IResourceName, sys::IEquatable<JobName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/tenants/{tenant}/jobs/{jobs}");

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
            return new JobName(resourceName[0], resourceName[1], resourceName[2]);
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
                result = new JobName(resourceName[0], resourceName[1], resourceName[2]);
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
        /// <param name="tenantId">The tenant ID. Must not be <c>null</c>.</param>
        /// <param name="jobsId">The jobs ID. Must not be <c>null</c>.</param>
        public JobName(string projectId, string tenantId, string jobsId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TenantId = gax::GaxPreconditions.CheckNotNull(tenantId, nameof(tenantId));
            JobsId = gax::GaxPreconditions.CheckNotNull(jobsId, nameof(jobsId));
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
        /// The jobs ID. Never <c>null</c>.
        /// </summary>
        public string JobsId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TenantId, JobsId);

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
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>JobName: A resource of type 'job'.</description></item>
    /// <item><description>JobWithoutTenantName: A resource of type 'job_without_tenant'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class JobNameOneof : gax::IResourceName, sys::IEquatable<JobNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="JobNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'job'.
            /// </summary>
            JobName = 1,

            /// <summary>
            /// A resource of type 'job_without_tenant'.
            /// </summary>
            JobWithoutTenantName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="JobNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>JobName: A resource of type 'job'.</description></item>
        /// <item><description>JobWithoutTenantName: A resource of type 'job_without_tenant'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="JobNameOneof"/> if successful.</returns>
        public static JobNameOneof Parse(string name, bool allowUnknown)
        {
            JobNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="JobNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>JobName: A resource of type 'job'.</description></item>
        /// <item><description>JobWithoutTenantName: A resource of type 'job_without_tenant'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="JobNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out JobNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            JobName jobName;
            if (JobName.TryParse(name, out jobName))
            {
                result = new JobNameOneof(OneofType.JobName, jobName);
                return true;
            }
            JobWithoutTenantName jobWithoutTenantName;
            if (JobWithoutTenantName.TryParse(name, out jobWithoutTenantName))
            {
                result = new JobNameOneof(OneofType.JobWithoutTenantName, jobWithoutTenantName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new JobNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="JobNameOneof"/> from the provided <see cref="JobName"/>
        /// </summary>
        /// <param name="jobName">The <see cref="JobName"/> to be contained within
        /// the returned <see cref="JobNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="JobNameOneof"/>, containing <paramref name="jobName"/>.</returns>
        public static JobNameOneof From(JobName jobName) => new JobNameOneof(OneofType.JobName, jobName);

        /// <summary>
        /// Construct a new instance of <see cref="JobNameOneof"/> from the provided <see cref="JobWithoutTenantName"/>
        /// </summary>
        /// <param name="jobWithoutTenantName">The <see cref="JobWithoutTenantName"/> to be contained within
        /// the returned <see cref="JobNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="JobNameOneof"/>, containing <paramref name="jobWithoutTenantName"/>.</returns>
        public static JobNameOneof From(JobWithoutTenantName jobWithoutTenantName) => new JobNameOneof(OneofType.JobWithoutTenantName, jobWithoutTenantName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.JobName: return name is JobName;
                case OneofType.JobWithoutTenantName: return name is JobWithoutTenantName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="JobNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public JobNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="JobName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="JobName"/>.
        /// </remarks>
        public JobName JobName => CheckAndReturn<JobName>(OneofType.JobName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="JobWithoutTenantName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="JobWithoutTenantName"/>.
        /// </remarks>
        public JobWithoutTenantName JobWithoutTenantName => CheckAndReturn<JobWithoutTenantName>(OneofType.JobWithoutTenantName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as JobNameOneof);

        /// <inheritdoc />
        public bool Equals(JobNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(JobNameOneof a, JobNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(JobNameOneof a, JobNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'job_without_tenant' resource.
    /// </summary>
    public sealed partial class JobWithoutTenantName : gax::IResourceName, sys::IEquatable<JobWithoutTenantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/jobs/{jobs}");

        /// <summary>
        /// Parses the given job_without_tenant resource name in string form into a new
        /// <see cref="JobWithoutTenantName"/> instance.
        /// </summary>
        /// <param name="jobWithoutTenantName">The job_without_tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobWithoutTenantName"/> if successful.</returns>
        public static JobWithoutTenantName Parse(string jobWithoutTenantName)
        {
            gax::GaxPreconditions.CheckNotNull(jobWithoutTenantName, nameof(jobWithoutTenantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(jobWithoutTenantName);
            return new JobWithoutTenantName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given job_without_tenant resource name in string form into a new
        /// <see cref="JobWithoutTenantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="jobWithoutTenantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="jobWithoutTenantName">The job_without_tenant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="JobWithoutTenantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobWithoutTenantName, out JobWithoutTenantName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobWithoutTenantName, nameof(jobWithoutTenantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(jobWithoutTenantName, out resourceName))
            {
                result = new JobWithoutTenantName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="JobWithoutTenantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="jobsId">The jobs ID. Must not be <c>null</c>.</param>
        public JobWithoutTenantName(string projectId, string jobsId)
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
        public override bool Equals(object obj) => Equals(obj as JobWithoutTenantName);

        /// <inheritdoc />
        public bool Equals(JobWithoutTenantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(JobWithoutTenantName a, JobWithoutTenantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(JobWithoutTenantName a, JobWithoutTenantName b) => !(a == b);
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

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>TenantName: A resource of type 'tenant'.</description></item>
    /// <item><description>ProjectName: A resource of type 'project'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class TenantOrProjectNameOneof : gax::IResourceName, sys::IEquatable<TenantOrProjectNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="TenantOrProjectNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'tenant'.
            /// </summary>
            TenantName = 1,

            /// <summary>
            /// A resource of type 'project'.
            /// </summary>
            ProjectName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="TenantOrProjectNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>TenantName: A resource of type 'tenant'.</description></item>
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="TenantOrProjectNameOneof"/> if successful.</returns>
        public static TenantOrProjectNameOneof Parse(string name, bool allowUnknown)
        {
            TenantOrProjectNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="TenantOrProjectNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>TenantName: A resource of type 'tenant'.</description></item>
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TenantOrProjectNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out TenantOrProjectNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            TenantName tenantName;
            if (TenantName.TryParse(name, out tenantName))
            {
                result = new TenantOrProjectNameOneof(OneofType.TenantName, tenantName);
                return true;
            }
            Google.Api.Gax.ResourceNames.ProjectName projectName;
            if (Google.Api.Gax.ResourceNames.ProjectName.TryParse(name, out projectName))
            {
                result = new TenantOrProjectNameOneof(OneofType.ProjectName, projectName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new TenantOrProjectNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="TenantOrProjectNameOneof"/> from the provided <see cref="TenantName"/>
        /// </summary>
        /// <param name="tenantName">The <see cref="TenantName"/> to be contained within
        /// the returned <see cref="TenantOrProjectNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TenantOrProjectNameOneof"/>, containing <paramref name="tenantName"/>.</returns>
        public static TenantOrProjectNameOneof From(TenantName tenantName) => new TenantOrProjectNameOneof(OneofType.TenantName, tenantName);

        /// <summary>
        /// Construct a new instance of <see cref="TenantOrProjectNameOneof"/> from the provided <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>
        /// </summary>
        /// <param name="projectName">The <see cref="Google.Api.Gax.ResourceNames.ProjectName"/> to be contained within
        /// the returned <see cref="TenantOrProjectNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TenantOrProjectNameOneof"/>, containing <paramref name="projectName"/>.</returns>
        public static TenantOrProjectNameOneof From(Google.Api.Gax.ResourceNames.ProjectName projectName) => new TenantOrProjectNameOneof(OneofType.ProjectName, projectName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.TenantName: return name is TenantName;
                case OneofType.ProjectName: return name is Google.Api.Gax.ResourceNames.ProjectName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TenantOrProjectNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public TenantOrProjectNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="TenantName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="TenantName"/>.
        /// </remarks>
        public TenantName TenantName => CheckAndReturn<TenantName>(OneofType.TenantName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>.
        /// </remarks>
        public Google.Api.Gax.ResourceNames.ProjectName ProjectName => CheckAndReturn<Google.Api.Gax.ResourceNames.ProjectName>(OneofType.ProjectName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TenantOrProjectNameOneof);

        /// <inheritdoc />
        public bool Equals(TenantOrProjectNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TenantOrProjectNameOneof a, TenantOrProjectNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TenantOrProjectNameOneof a, TenantOrProjectNameOneof b) => !(a == b);
    }


    public partial class Application
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ApplicationName ApplicationName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ApplicationName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class BatchDeleteJobsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Company
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyNameOneof CompanyNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CompleteQueryRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyNameOneof"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyNameOneof CompanyAsCompanyNameOneof
        {
            get { return string.IsNullOrEmpty(Company) ? null : Google.Cloud.Talent.V4Beta1.CompanyNameOneof.Parse(Company, true); }
            set { Company = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateApplicationRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ProfileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ProfileName ParentAsProfileName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.ProfileName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateClientEventRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateCompanyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
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

    public partial class DeleteApplicationRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ApplicationName ApplicationName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ApplicationName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteCompanyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyNameOneof CompanyNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobNameOneof JobNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobNameOneof.Parse(Name, true); }
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

    public partial class GetApplicationRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ApplicationName ApplicationName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.ApplicationName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetCompanyRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyNameOneof CompanyNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.CompanyNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobNameOneof JobNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobNameOneof.Parse(Name, true); }
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
        /// <see cref="Google.Cloud.Talent.V4Beta1.JobNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.JobNameOneof JobNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Talent.V4Beta1.JobNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.CompanyNameOneof"/>-typed view over the <see cref="Company"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.CompanyNameOneof CompanyAsCompanyNameOneof
        {
            get { return string.IsNullOrEmpty(Company) ? null : Google.Cloud.Talent.V4Beta1.CompanyNameOneof.Parse(Company, true); }
            set { Company = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListApplicationsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.ProfileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.ProfileName ParentAsProfileName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.ProfileName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListCompaniesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListJobsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
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
        /// <see cref="Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof ParentAsTenantOrProjectNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Talent.V4Beta1.TenantOrProjectNameOneof.Parse(Parent, true); }
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