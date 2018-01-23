// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Dlp.V2Beta2
{
    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : IResourceName, IEquatable<OrganizationName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationName, out resourceName))
            {
                result = new OrganizationName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationName(string organizationId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc />
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'deidentify_template' resource.
    /// </summary>
    public sealed partial class DeidentifyTemplateName : IResourceName, IEquatable<DeidentifyTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given deidentify_template resource name in string form into a new
        /// <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <param name="deidentifyTemplateName">The deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateName"/> if successful.</returns>
        public static DeidentifyTemplateName Parse(string deidentifyTemplateName)
        {
            GaxPreconditions.CheckNotNull(deidentifyTemplateName, nameof(deidentifyTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(deidentifyTemplateName);
            return new DeidentifyTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given deidentify_template resource name in string form into a new
        /// <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="deidentifyTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="deidentifyTemplateName">The deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DeidentifyTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplateName, out DeidentifyTemplateName result)
        {
            GaxPreconditions.CheckNotNull(deidentifyTemplateName, nameof(deidentifyTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = new DeidentifyTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DeidentifyTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public DeidentifyTemplateName(string organizationId, string deidentifyTemplateId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            DeidentifyTemplateId = GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The deidentifyTemplate ID. Never <c>null</c>.
        /// </summary>
        public string DeidentifyTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplateName);

        /// <inheritdoc />
        public bool Equals(DeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DeidentifyTemplateName a, DeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DeidentifyTemplateName a, DeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'deidentify_template_2' resource.
    /// </summary>
    public sealed partial class DeidentifyTemplate2Name : IResourceName, IEquatable<DeidentifyTemplate2Name>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given deidentify_template_2 resource name in string form into a new
        /// <see cref="DeidentifyTemplate2Name"/> instance.
        /// </summary>
        /// <param name="deidentifyTemplate2Name">The deidentify_template_2 resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplate2Name"/> if successful.</returns>
        public static DeidentifyTemplate2Name Parse(string deidentifyTemplate2Name)
        {
            GaxPreconditions.CheckNotNull(deidentifyTemplate2Name, nameof(deidentifyTemplate2Name));
            TemplatedResourceName resourceName = s_template.ParseName(deidentifyTemplate2Name);
            return new DeidentifyTemplate2Name(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given deidentify_template_2 resource name in string form into a new
        /// <see cref="DeidentifyTemplate2Name"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="deidentifyTemplate2Name"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="deidentifyTemplate2Name">The deidentify_template_2 resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DeidentifyTemplate2Name"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplate2Name, out DeidentifyTemplate2Name result)
        {
            GaxPreconditions.CheckNotNull(deidentifyTemplate2Name, nameof(deidentifyTemplate2Name));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(deidentifyTemplate2Name, out resourceName))
            {
                result = new DeidentifyTemplate2Name(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DeidentifyTemplate2Name"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public DeidentifyTemplate2Name(string projectId, string deidentifyTemplateId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DeidentifyTemplateId = GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The deidentifyTemplate ID. Never <c>null</c>.
        /// </summary>
        public string DeidentifyTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplate2Name);

        /// <inheritdoc />
        public bool Equals(DeidentifyTemplate2Name other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DeidentifyTemplate2Name a, DeidentifyTemplate2Name b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DeidentifyTemplate2Name a, DeidentifyTemplate2Name b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'inspect_template' resource.
    /// </summary>
    public sealed partial class InspectTemplateName : IResourceName, IEquatable<InspectTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given inspect_template resource name in string form into a new
        /// <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <param name="inspectTemplateName">The inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InspectTemplateName"/> if successful.</returns>
        public static InspectTemplateName Parse(string inspectTemplateName)
        {
            GaxPreconditions.CheckNotNull(inspectTemplateName, nameof(inspectTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(inspectTemplateName);
            return new InspectTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given inspect_template resource name in string form into a new
        /// <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="inspectTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="inspectTemplateName">The inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InspectTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplateName, out InspectTemplateName result)
        {
            GaxPreconditions.CheckNotNull(inspectTemplateName, nameof(inspectTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(inspectTemplateName, out resourceName))
            {
                result = new InspectTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InspectTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public InspectTemplateName(string organizationId, string inspectTemplateId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            InspectTemplateId = GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The inspectTemplate ID. Never <c>null</c>.
        /// </summary>
        public string InspectTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InspectTemplateName);

        /// <inheritdoc />
        public bool Equals(InspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InspectTemplateName a, InspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InspectTemplateName a, InspectTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'inspect_template_2' resource.
    /// </summary>
    public sealed partial class InspectTemplate2Name : IResourceName, IEquatable<InspectTemplate2Name>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given inspect_template_2 resource name in string form into a new
        /// <see cref="InspectTemplate2Name"/> instance.
        /// </summary>
        /// <param name="inspectTemplate2Name">The inspect_template_2 resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InspectTemplate2Name"/> if successful.</returns>
        public static InspectTemplate2Name Parse(string inspectTemplate2Name)
        {
            GaxPreconditions.CheckNotNull(inspectTemplate2Name, nameof(inspectTemplate2Name));
            TemplatedResourceName resourceName = s_template.ParseName(inspectTemplate2Name);
            return new InspectTemplate2Name(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given inspect_template_2 resource name in string form into a new
        /// <see cref="InspectTemplate2Name"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="inspectTemplate2Name"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="inspectTemplate2Name">The inspect_template_2 resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InspectTemplate2Name"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplate2Name, out InspectTemplate2Name result)
        {
            GaxPreconditions.CheckNotNull(inspectTemplate2Name, nameof(inspectTemplate2Name));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(inspectTemplate2Name, out resourceName))
            {
                result = new InspectTemplate2Name(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InspectTemplate2Name"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public InspectTemplate2Name(string projectId, string inspectTemplateId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InspectTemplateId = GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The inspectTemplate ID. Never <c>null</c>.
        /// </summary>
        public string InspectTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InspectTemplate2Name);

        /// <inheritdoc />
        public bool Equals(InspectTemplate2Name other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InspectTemplate2Name a, InspectTemplate2Name b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InspectTemplate2Name a, InspectTemplate2Name b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'dlp_job' resource.
    /// </summary>
    public sealed partial class DlpJobName : IResourceName, IEquatable<DlpJobName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/dlpJobs/{dlp_job}");

        /// <summary>
        /// Parses the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName)
        {
            GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            TemplatedResourceName resourceName = s_template.ParseName(dlpJobName);
            return new DlpJobName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="dlpJobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DlpJobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, out DlpJobName result)
        {
            GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(dlpJobName, out resourceName))
            {
                result = new DlpJobName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DlpJobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dlpJobId">The dlpJob ID. Must not be <c>null</c>.</param>
        public DlpJobName(string projectId, string dlpJobId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DlpJobId = GaxPreconditions.CheckNotNull(dlpJobId, nameof(dlpJobId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The dlpJob ID. Never <c>null</c>.
        /// </summary>
        public string DlpJobId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DlpJobId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DlpJobName);

        /// <inheritdoc />
        public bool Equals(DlpJobName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DlpJobName a, DlpJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DlpJobName a, DlpJobName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>DeidentifyTemplateName: A resource of type 'deidentify_template'.</description></item>
    /// <item><description>DeidentifyTemplate2Name: A resource of type 'deidentify_template_2'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class DeidentifyTemplateNameOneof : IResourceName, IEquatable<DeidentifyTemplateNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="DeidentifyTemplateNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'deidentify_template'.
            /// </summary>
            DeidentifyTemplateName = 1,

            /// <summary>
            /// A resource of type 'deidentify_template_2'.
            /// </summary>
            DeidentifyTemplate2Name = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>DeidentifyTemplateName: A resource of type 'deidentify_template'.</description></item>
        /// <item><description>DeidentifyTemplate2Name: A resource of type 'deidentify_template_2'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateNameOneof"/> if successful.</returns>
        public static DeidentifyTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            DeidentifyTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>DeidentifyTemplateName: A resource of type 'deidentify_template'.</description></item>
        /// <item><description>DeidentifyTemplate2Name: A resource of type 'deidentify_template_2'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DeidentifyTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out DeidentifyTemplateNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            DeidentifyTemplateName deidentifyTemplateName;
            if (DeidentifyTemplateName.TryParse(name, out deidentifyTemplateName))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.DeidentifyTemplateName, deidentifyTemplateName);
                return true;
            }
            DeidentifyTemplate2Name deidentifyTemplate2Name;
            if (DeidentifyTemplate2Name.TryParse(name, out deidentifyTemplate2Name))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.DeidentifyTemplate2Name, deidentifyTemplate2Name);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new DeidentifyTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="DeidentifyTemplateName"/>
        /// </summary>
        /// <param name="deidentifyTemplateName">The <see cref="DeidentifyTemplateName"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="deidentifyTemplateName"/>.</returns>
        public static DeidentifyTemplateNameOneof From(DeidentifyTemplateName deidentifyTemplateName) => new DeidentifyTemplateNameOneof(OneofType.DeidentifyTemplateName, deidentifyTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="DeidentifyTemplate2Name"/>
        /// </summary>
        /// <param name="deidentifyTemplate2Name">The <see cref="DeidentifyTemplate2Name"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="deidentifyTemplate2Name"/>.</returns>
        public static DeidentifyTemplateNameOneof From(DeidentifyTemplate2Name deidentifyTemplate2Name) => new DeidentifyTemplateNameOneof(OneofType.DeidentifyTemplate2Name, deidentifyTemplate2Name);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.DeidentifyTemplateName: return name is DeidentifyTemplateName;
                case OneofType.DeidentifyTemplate2Name: return name is DeidentifyTemplate2Name;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DeidentifyTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public DeidentifyTemplateNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="DeidentifyTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="DeidentifyTemplateName"/>.
        /// </remarks>
        public DeidentifyTemplateName DeidentifyTemplateName => CheckAndReturn<DeidentifyTemplateName>(OneofType.DeidentifyTemplateName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="DeidentifyTemplate2Name"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="DeidentifyTemplate2Name"/>.
        /// </remarks>
        public DeidentifyTemplate2Name DeidentifyTemplate2Name => CheckAndReturn<DeidentifyTemplate2Name>(OneofType.DeidentifyTemplate2Name);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplateNameOneof);

        /// <inheritdoc />
        public bool Equals(DeidentifyTemplateNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DeidentifyTemplateNameOneof a, DeidentifyTemplateNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DeidentifyTemplateNameOneof a, DeidentifyTemplateNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>InspectTemplateName: A resource of type 'inspect_template'.</description></item>
    /// <item><description>InspectTemplate2Name: A resource of type 'inspect_template_2'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class InspectTemplateNameOneof : IResourceName, IEquatable<InspectTemplateNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="InspectTemplateNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'inspect_template'.
            /// </summary>
            InspectTemplateName = 1,

            /// <summary>
            /// A resource of type 'inspect_template_2'.
            /// </summary>
            InspectTemplate2Name = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>InspectTemplateName: A resource of type 'inspect_template'.</description></item>
        /// <item><description>InspectTemplate2Name: A resource of type 'inspect_template_2'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="InspectTemplateNameOneof"/> if successful.</returns>
        public static InspectTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            InspectTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>InspectTemplateName: A resource of type 'inspect_template'.</description></item>
        /// <item><description>InspectTemplate2Name: A resource of type 'inspect_template_2'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InspectTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out InspectTemplateNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            InspectTemplateName inspectTemplateName;
            if (InspectTemplateName.TryParse(name, out inspectTemplateName))
            {
                result = new InspectTemplateNameOneof(OneofType.InspectTemplateName, inspectTemplateName);
                return true;
            }
            InspectTemplate2Name inspectTemplate2Name;
            if (InspectTemplate2Name.TryParse(name, out inspectTemplate2Name))
            {
                result = new InspectTemplateNameOneof(OneofType.InspectTemplate2Name, inspectTemplate2Name);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new InspectTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="InspectTemplateName"/>
        /// </summary>
        /// <param name="inspectTemplateName">The <see cref="InspectTemplateName"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="inspectTemplateName"/>.</returns>
        public static InspectTemplateNameOneof From(InspectTemplateName inspectTemplateName) => new InspectTemplateNameOneof(OneofType.InspectTemplateName, inspectTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="InspectTemplate2Name"/>
        /// </summary>
        /// <param name="inspectTemplate2Name">The <see cref="InspectTemplate2Name"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="inspectTemplate2Name"/>.</returns>
        public static InspectTemplateNameOneof From(InspectTemplate2Name inspectTemplate2Name) => new InspectTemplateNameOneof(OneofType.InspectTemplate2Name, inspectTemplate2Name);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.InspectTemplateName: return name is InspectTemplateName;
                case OneofType.InspectTemplate2Name: return name is InspectTemplate2Name;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InspectTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public InspectTemplateNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="InspectTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="InspectTemplateName"/>.
        /// </remarks>
        public InspectTemplateName InspectTemplateName => CheckAndReturn<InspectTemplateName>(OneofType.InspectTemplateName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="InspectTemplate2Name"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="InspectTemplate2Name"/>.
        /// </remarks>
        public InspectTemplate2Name InspectTemplate2Name => CheckAndReturn<InspectTemplate2Name>(OneofType.InspectTemplate2Name);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InspectTemplateNameOneof);

        /// <inheritdoc />
        public bool Equals(InspectTemplateNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InspectTemplateNameOneof a, InspectTemplateNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InspectTemplateNameOneof a, InspectTemplateNameOneof b) => !(a == b);
    }


    public partial class AnalyzeDataSourceRiskRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CancelDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeidentifyContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InspectContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InspectDataSourceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDeidentifyTemplatesRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDlpJobsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInspectTemplatesRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RedactImageRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ReidentifyContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}