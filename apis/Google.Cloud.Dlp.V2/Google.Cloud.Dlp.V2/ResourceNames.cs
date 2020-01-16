// Copyright 2020 Google LLC
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

namespace Google.Cloud.Dlp.V2
{
    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
    /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class DeidentifyTemplateNameOneof : gax::IResourceName, sys::IEquatable<DeidentifyTemplateNameOneof>
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
            /// A resource of type 'organization_deidentify_template'.
            /// </summary>
            OrganizationDeidentifyTemplateName = 1,

            /// <summary>
            /// A resource of type 'project_deidentify_template'.
            /// </summary>
            ProjectDeidentifyTemplateName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
        /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateNameOneof"/> if successful.</returns>
        public static DeidentifyTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            DeidentifyTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
        /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DeidentifyTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out DeidentifyTemplateNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationDeidentifyTemplateName organizationDeidentifyTemplateName;
            if (OrganizationDeidentifyTemplateName.TryParse(name, out organizationDeidentifyTemplateName))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.OrganizationDeidentifyTemplateName, organizationDeidentifyTemplateName);
                return true;
            }
            ProjectDeidentifyTemplateName projectDeidentifyTemplateName;
            if (ProjectDeidentifyTemplateName.TryParse(name, out projectDeidentifyTemplateName))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.ProjectDeidentifyTemplateName, projectDeidentifyTemplateName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new DeidentifyTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="OrganizationDeidentifyTemplateName"/>
        /// </summary>
        /// <param name="organizationDeidentifyTemplateName">The <see cref="OrganizationDeidentifyTemplateName"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="organizationDeidentifyTemplateName"/>.</returns>
        public static DeidentifyTemplateNameOneof From(OrganizationDeidentifyTemplateName organizationDeidentifyTemplateName) => new DeidentifyTemplateNameOneof(OneofType.OrganizationDeidentifyTemplateName, organizationDeidentifyTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="ProjectDeidentifyTemplateName"/>
        /// </summary>
        /// <param name="projectDeidentifyTemplateName">The <see cref="ProjectDeidentifyTemplateName"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="projectDeidentifyTemplateName"/>.</returns>
        public static DeidentifyTemplateNameOneof From(ProjectDeidentifyTemplateName projectDeidentifyTemplateName) => new DeidentifyTemplateNameOneof(OneofType.ProjectDeidentifyTemplateName, projectDeidentifyTemplateName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationDeidentifyTemplateName: return name is OrganizationDeidentifyTemplateName;
                case OneofType.ProjectDeidentifyTemplateName: return name is ProjectDeidentifyTemplateName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DeidentifyTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public DeidentifyTemplateNameOneof(OneofType type, gax::IResourceName name)
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
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="OrganizationDeidentifyTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationDeidentifyTemplateName"/>.
        /// </remarks>
        public OrganizationDeidentifyTemplateName OrganizationDeidentifyTemplateName => CheckAndReturn<OrganizationDeidentifyTemplateName>(OneofType.OrganizationDeidentifyTemplateName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectDeidentifyTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectDeidentifyTemplateName"/>.
        /// </remarks>
        public ProjectDeidentifyTemplateName ProjectDeidentifyTemplateName => CheckAndReturn<ProjectDeidentifyTemplateName>(OneofType.ProjectDeidentifyTemplateName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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
    /// Resource name for the 'dlp_job' resource.
    /// </summary>
    public sealed partial class DlpJobName : gax::IResourceName, sys::IEquatable<DlpJobName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/dlpJobs/{dlp_job}");

        /// <summary>
        /// Parses the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName)
        {
            gax::GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(dlpJobName);
            return new DlpJobName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="dlpJobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DlpJobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, out DlpJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            gax::TemplatedResourceName resourceName;
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

        /// <summary>Formats the IDs into the string representation of the <see cref="DlpJobName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="dlpJobId">The <c>dlpJob</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DlpJobName"/>.</returns>
        public static string Format(string projectId, string dlpJobId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DlpJobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dlpJobId">The dlpJob ID. Must not be <c>null</c>.</param>
        public DlpJobName(string projectId, string dlpJobId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DlpJobId = gax::GaxPreconditions.CheckNotNull(dlpJobId, nameof(dlpJobId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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
    /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
    /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class InspectTemplateNameOneof : gax::IResourceName, sys::IEquatable<InspectTemplateNameOneof>
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
            /// A resource of type 'organization_inspect_template'.
            /// </summary>
            OrganizationInspectTemplateName = 1,

            /// <summary>
            /// A resource of type 'project_inspect_template'.
            /// </summary>
            ProjectInspectTemplateName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
        /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="InspectTemplateNameOneof"/> if successful.</returns>
        public static InspectTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            InspectTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
        /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InspectTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out InspectTemplateNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationInspectTemplateName organizationInspectTemplateName;
            if (OrganizationInspectTemplateName.TryParse(name, out organizationInspectTemplateName))
            {
                result = new InspectTemplateNameOneof(OneofType.OrganizationInspectTemplateName, organizationInspectTemplateName);
                return true;
            }
            ProjectInspectTemplateName projectInspectTemplateName;
            if (ProjectInspectTemplateName.TryParse(name, out projectInspectTemplateName))
            {
                result = new InspectTemplateNameOneof(OneofType.ProjectInspectTemplateName, projectInspectTemplateName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new InspectTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="OrganizationInspectTemplateName"/>
        /// </summary>
        /// <param name="organizationInspectTemplateName">The <see cref="OrganizationInspectTemplateName"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="organizationInspectTemplateName"/>.</returns>
        public static InspectTemplateNameOneof From(OrganizationInspectTemplateName organizationInspectTemplateName) => new InspectTemplateNameOneof(OneofType.OrganizationInspectTemplateName, organizationInspectTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="ProjectInspectTemplateName"/>
        /// </summary>
        /// <param name="projectInspectTemplateName">The <see cref="ProjectInspectTemplateName"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="projectInspectTemplateName"/>.</returns>
        public static InspectTemplateNameOneof From(ProjectInspectTemplateName projectInspectTemplateName) => new InspectTemplateNameOneof(OneofType.ProjectInspectTemplateName, projectInspectTemplateName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationInspectTemplateName: return name is OrganizationInspectTemplateName;
                case OneofType.ProjectInspectTemplateName: return name is ProjectInspectTemplateName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InspectTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public InspectTemplateNameOneof(OneofType type, gax::IResourceName name)
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
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="OrganizationInspectTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationInspectTemplateName"/>.
        /// </remarks>
        public OrganizationInspectTemplateName OrganizationInspectTemplateName => CheckAndReturn<OrganizationInspectTemplateName>(OneofType.OrganizationInspectTemplateName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectInspectTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectInspectTemplateName"/>.
        /// </remarks>
        public ProjectInspectTemplateName ProjectInspectTemplateName => CheckAndReturn<ProjectInspectTemplateName>(OneofType.ProjectInspectTemplateName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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

    /// <summary>
    /// Resource name for the 'organization_deidentify_template' resource.
    /// </summary>
    public sealed partial class OrganizationDeidentifyTemplateName : gax::IResourceName, sys::IEquatable<OrganizationDeidentifyTemplateName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given organization_deidentify_template resource name in string form into a new
        /// <see cref="OrganizationDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <param name="organizationDeidentifyTemplateName">The organization_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationDeidentifyTemplateName"/> if successful.</returns>
        public static OrganizationDeidentifyTemplateName Parse(string organizationDeidentifyTemplateName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationDeidentifyTemplateName, nameof(organizationDeidentifyTemplateName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationDeidentifyTemplateName);
            return new OrganizationDeidentifyTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_deidentify_template resource name in string form into a new
        /// <see cref="OrganizationDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationDeidentifyTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationDeidentifyTemplateName">The organization_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationDeidentifyTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationDeidentifyTemplateName, out OrganizationDeidentifyTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationDeidentifyTemplateName, nameof(organizationDeidentifyTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationDeidentifyTemplateName, out resourceName))
            {
                result = new OrganizationDeidentifyTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationDeidentifyTemplateName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The <c>deidentifyTemplate</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationDeidentifyTemplateName"/>.</returns>
        public static string Format(string organizationId, string deidentifyTemplateId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationDeidentifyTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public OrganizationDeidentifyTemplateName(string organizationId, string deidentifyTemplateId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            DeidentifyTemplateId = gax::GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationDeidentifyTemplateName);

        /// <inheritdoc />
        public bool Equals(OrganizationDeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationDeidentifyTemplateName a, OrganizationDeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationDeidentifyTemplateName a, OrganizationDeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_inspect_template' resource.
    /// </summary>
    public sealed partial class OrganizationInspectTemplateName : gax::IResourceName, sys::IEquatable<OrganizationInspectTemplateName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given organization_inspect_template resource name in string form into a new
        /// <see cref="OrganizationInspectTemplateName"/> instance.
        /// </summary>
        /// <param name="organizationInspectTemplateName">The organization_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationInspectTemplateName"/> if successful.</returns>
        public static OrganizationInspectTemplateName Parse(string organizationInspectTemplateName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationInspectTemplateName, nameof(organizationInspectTemplateName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationInspectTemplateName);
            return new OrganizationInspectTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_inspect_template resource name in string form into a new
        /// <see cref="OrganizationInspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationInspectTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationInspectTemplateName">The organization_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationInspectTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationInspectTemplateName, out OrganizationInspectTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationInspectTemplateName, nameof(organizationInspectTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationInspectTemplateName, out resourceName))
            {
                result = new OrganizationInspectTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationInspectTemplateName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The <c>inspectTemplate</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationInspectTemplateName"/>.</returns>
        public static string Format(string organizationId, string inspectTemplateId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationInspectTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public OrganizationInspectTemplateName(string organizationId, string inspectTemplateId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            InspectTemplateId = gax::GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationInspectTemplateName);

        /// <inheritdoc />
        public bool Equals(OrganizationInspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationInspectTemplateName a, OrganizationInspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationInspectTemplateName a, OrganizationInspectTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_stored_info_type' resource.
    /// </summary>
    public sealed partial class OrganizationStoredInfoTypeName : gax::IResourceName, sys::IEquatable<OrganizationStoredInfoTypeName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/storedInfoTypes/{stored_info_type}");

        /// <summary>
        /// Parses the given organization_stored_info_type resource name in string form into a new
        /// <see cref="OrganizationStoredInfoTypeName"/> instance.
        /// </summary>
        /// <param name="organizationStoredInfoTypeName">The organization_stored_info_type resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationStoredInfoTypeName"/> if successful.</returns>
        public static OrganizationStoredInfoTypeName Parse(string organizationStoredInfoTypeName)
        {
            gax::GaxPreconditions.CheckNotNull(organizationStoredInfoTypeName, nameof(organizationStoredInfoTypeName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(organizationStoredInfoTypeName);
            return new OrganizationStoredInfoTypeName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_stored_info_type resource name in string form into a new
        /// <see cref="OrganizationStoredInfoTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="organizationStoredInfoTypeName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationStoredInfoTypeName">The organization_stored_info_type resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationStoredInfoTypeName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationStoredInfoTypeName, out OrganizationStoredInfoTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationStoredInfoTypeName, nameof(organizationStoredInfoTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationStoredInfoTypeName, out resourceName))
            {
                result = new OrganizationStoredInfoTypeName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="OrganizationStoredInfoTypeName"/>.</summary>
        /// <param name="organizationId">The <c>organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="storedInfoTypeId">The <c>storedInfoType</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="OrganizationStoredInfoTypeName"/>.</returns>
        public static string Format(string organizationId, string storedInfoTypeId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationStoredInfoTypeName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="storedInfoTypeId">The storedInfoType ID. Must not be <c>null</c>.</param>
        public OrganizationStoredInfoTypeName(string organizationId, string storedInfoTypeId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            StoredInfoTypeId = gax::GaxPreconditions.CheckNotNull(storedInfoTypeId, nameof(storedInfoTypeId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The storedInfoType ID. Never <c>null</c>.
        /// </summary>
        public string StoredInfoTypeId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, StoredInfoTypeId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationStoredInfoTypeName);

        /// <inheritdoc />
        public bool Equals(OrganizationStoredInfoTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationStoredInfoTypeName a, OrganizationStoredInfoTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationStoredInfoTypeName a, OrganizationStoredInfoTypeName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_deidentify_template' resource.
    /// </summary>
    public sealed partial class ProjectDeidentifyTemplateName : gax::IResourceName, sys::IEquatable<ProjectDeidentifyTemplateName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given project_deidentify_template resource name in string form into a new
        /// <see cref="ProjectDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <param name="projectDeidentifyTemplateName">The project_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectDeidentifyTemplateName"/> if successful.</returns>
        public static ProjectDeidentifyTemplateName Parse(string projectDeidentifyTemplateName)
        {
            gax::GaxPreconditions.CheckNotNull(projectDeidentifyTemplateName, nameof(projectDeidentifyTemplateName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectDeidentifyTemplateName);
            return new ProjectDeidentifyTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_deidentify_template resource name in string form into a new
        /// <see cref="ProjectDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectDeidentifyTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectDeidentifyTemplateName">The project_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectDeidentifyTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectDeidentifyTemplateName, out ProjectDeidentifyTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectDeidentifyTemplateName, nameof(projectDeidentifyTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectDeidentifyTemplateName, out resourceName))
            {
                result = new ProjectDeidentifyTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectDeidentifyTemplateName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The <c>deidentifyTemplate</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectDeidentifyTemplateName"/>.</returns>
        public static string Format(string projectId, string deidentifyTemplateId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectDeidentifyTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public ProjectDeidentifyTemplateName(string projectId, string deidentifyTemplateId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DeidentifyTemplateId = gax::GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectDeidentifyTemplateName);

        /// <inheritdoc />
        public bool Equals(ProjectDeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectDeidentifyTemplateName a, ProjectDeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectDeidentifyTemplateName a, ProjectDeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_inspect_template' resource.
    /// </summary>
    public sealed partial class ProjectInspectTemplateName : gax::IResourceName, sys::IEquatable<ProjectInspectTemplateName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given project_inspect_template resource name in string form into a new
        /// <see cref="ProjectInspectTemplateName"/> instance.
        /// </summary>
        /// <param name="projectInspectTemplateName">The project_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectInspectTemplateName"/> if successful.</returns>
        public static ProjectInspectTemplateName Parse(string projectInspectTemplateName)
        {
            gax::GaxPreconditions.CheckNotNull(projectInspectTemplateName, nameof(projectInspectTemplateName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectInspectTemplateName);
            return new ProjectInspectTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_inspect_template resource name in string form into a new
        /// <see cref="ProjectInspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectInspectTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectInspectTemplateName">The project_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectInspectTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectInspectTemplateName, out ProjectInspectTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectInspectTemplateName, nameof(projectInspectTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectInspectTemplateName, out resourceName))
            {
                result = new ProjectInspectTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectInspectTemplateName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The <c>inspectTemplate</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectInspectTemplateName"/>.</returns>
        public static string Format(string projectId, string inspectTemplateId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectInspectTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public ProjectInspectTemplateName(string projectId, string inspectTemplateId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InspectTemplateId = gax::GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectInspectTemplateName);

        /// <inheritdoc />
        public bool Equals(ProjectInspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectInspectTemplateName a, ProjectInspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectInspectTemplateName a, ProjectInspectTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_job_trigger' resource.
    /// </summary>
    public sealed partial class ProjectJobTriggerName : gax::IResourceName, sys::IEquatable<ProjectJobTriggerName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/jobTriggers/{job_trigger}");

        /// <summary>
        /// Parses the given project_job_trigger resource name in string form into a new
        /// <see cref="ProjectJobTriggerName"/> instance.
        /// </summary>
        /// <param name="projectJobTriggerName">The project_job_trigger resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectJobTriggerName"/> if successful.</returns>
        public static ProjectJobTriggerName Parse(string projectJobTriggerName)
        {
            gax::GaxPreconditions.CheckNotNull(projectJobTriggerName, nameof(projectJobTriggerName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectJobTriggerName);
            return new ProjectJobTriggerName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_job_trigger resource name in string form into a new
        /// <see cref="ProjectJobTriggerName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectJobTriggerName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectJobTriggerName">The project_job_trigger resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectJobTriggerName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectJobTriggerName, out ProjectJobTriggerName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectJobTriggerName, nameof(projectJobTriggerName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectJobTriggerName, out resourceName))
            {
                result = new ProjectJobTriggerName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectJobTriggerName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="jobTriggerId">The <c>jobTrigger</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectJobTriggerName"/>.</returns>
        public static string Format(string projectId, string jobTriggerId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(jobTriggerId, nameof(jobTriggerId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectJobTriggerName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="jobTriggerId">The jobTrigger ID. Must not be <c>null</c>.</param>
        public ProjectJobTriggerName(string projectId, string jobTriggerId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            JobTriggerId = gax::GaxPreconditions.CheckNotNull(jobTriggerId, nameof(jobTriggerId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The jobTrigger ID. Never <c>null</c>.
        /// </summary>
        public string JobTriggerId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, JobTriggerId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectJobTriggerName);

        /// <inheritdoc />
        public bool Equals(ProjectJobTriggerName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectJobTriggerName a, ProjectJobTriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectJobTriggerName a, ProjectJobTriggerName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_stored_info_type' resource.
    /// </summary>
    public sealed partial class ProjectStoredInfoTypeName : gax::IResourceName, sys::IEquatable<ProjectStoredInfoTypeName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/storedInfoTypes/{stored_info_type}");

        /// <summary>
        /// Parses the given project_stored_info_type resource name in string form into a new
        /// <see cref="ProjectStoredInfoTypeName"/> instance.
        /// </summary>
        /// <param name="projectStoredInfoTypeName">The project_stored_info_type resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectStoredInfoTypeName"/> if successful.</returns>
        public static ProjectStoredInfoTypeName Parse(string projectStoredInfoTypeName)
        {
            gax::GaxPreconditions.CheckNotNull(projectStoredInfoTypeName, nameof(projectStoredInfoTypeName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectStoredInfoTypeName);
            return new ProjectStoredInfoTypeName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_stored_info_type resource name in string form into a new
        /// <see cref="ProjectStoredInfoTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectStoredInfoTypeName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectStoredInfoTypeName">The project_stored_info_type resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectStoredInfoTypeName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectStoredInfoTypeName, out ProjectStoredInfoTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectStoredInfoTypeName, nameof(projectStoredInfoTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectStoredInfoTypeName, out resourceName))
            {
                result = new ProjectStoredInfoTypeName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectStoredInfoTypeName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="storedInfoTypeId">The <c>storedInfoType</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectStoredInfoTypeName"/>.</returns>
        public static string Format(string projectId, string storedInfoTypeId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectStoredInfoTypeName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="storedInfoTypeId">The storedInfoType ID. Must not be <c>null</c>.</param>
        public ProjectStoredInfoTypeName(string projectId, string storedInfoTypeId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            StoredInfoTypeId = gax::GaxPreconditions.CheckNotNull(storedInfoTypeId, nameof(storedInfoTypeId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The storedInfoType ID. Never <c>null</c>.
        /// </summary>
        public string StoredInfoTypeId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, StoredInfoTypeId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectStoredInfoTypeName);

        /// <inheritdoc />
        public bool Equals(ProjectStoredInfoTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectStoredInfoTypeName a, ProjectStoredInfoTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectStoredInfoTypeName a, ProjectStoredInfoTypeName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationStoredInfoTypeName: A resource of type 'organization_stored_info_type'.</description></item>
    /// <item><description>ProjectStoredInfoTypeName: A resource of type 'project_stored_info_type'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class StoredInfoTypeNameOneof : gax::IResourceName, sys::IEquatable<StoredInfoTypeNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="StoredInfoTypeNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'organization_stored_info_type'.
            /// </summary>
            OrganizationStoredInfoTypeName = 1,

            /// <summary>
            /// A resource of type 'project_stored_info_type'.
            /// </summary>
            ProjectStoredInfoTypeName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="StoredInfoTypeNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationStoredInfoTypeName: A resource of type 'organization_stored_info_type'.</description></item>
        /// <item><description>ProjectStoredInfoTypeName: A resource of type 'project_stored_info_type'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="StoredInfoTypeNameOneof"/> if successful.</returns>
        public static StoredInfoTypeNameOneof Parse(string name, bool allowUnknown)
        {
            StoredInfoTypeNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="StoredInfoTypeNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationStoredInfoTypeName: A resource of type 'organization_stored_info_type'.</description></item>
        /// <item><description>ProjectStoredInfoTypeName: A resource of type 'project_stored_info_type'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="StoredInfoTypeNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out StoredInfoTypeNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationStoredInfoTypeName organizationStoredInfoTypeName;
            if (OrganizationStoredInfoTypeName.TryParse(name, out organizationStoredInfoTypeName))
            {
                result = new StoredInfoTypeNameOneof(OneofType.OrganizationStoredInfoTypeName, organizationStoredInfoTypeName);
                return true;
            }
            ProjectStoredInfoTypeName projectStoredInfoTypeName;
            if (ProjectStoredInfoTypeName.TryParse(name, out projectStoredInfoTypeName))
            {
                result = new StoredInfoTypeNameOneof(OneofType.ProjectStoredInfoTypeName, projectStoredInfoTypeName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new StoredInfoTypeNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="StoredInfoTypeNameOneof"/> from the provided <see cref="OrganizationStoredInfoTypeName"/>
        /// </summary>
        /// <param name="organizationStoredInfoTypeName">The <see cref="OrganizationStoredInfoTypeName"/> to be contained within
        /// the returned <see cref="StoredInfoTypeNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="StoredInfoTypeNameOneof"/>, containing <paramref name="organizationStoredInfoTypeName"/>.</returns>
        public static StoredInfoTypeNameOneof From(OrganizationStoredInfoTypeName organizationStoredInfoTypeName) => new StoredInfoTypeNameOneof(OneofType.OrganizationStoredInfoTypeName, organizationStoredInfoTypeName);

        /// <summary>
        /// Construct a new instance of <see cref="StoredInfoTypeNameOneof"/> from the provided <see cref="ProjectStoredInfoTypeName"/>
        /// </summary>
        /// <param name="projectStoredInfoTypeName">The <see cref="ProjectStoredInfoTypeName"/> to be contained within
        /// the returned <see cref="StoredInfoTypeNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="StoredInfoTypeNameOneof"/>, containing <paramref name="projectStoredInfoTypeName"/>.</returns>
        public static StoredInfoTypeNameOneof From(ProjectStoredInfoTypeName projectStoredInfoTypeName) => new StoredInfoTypeNameOneof(OneofType.ProjectStoredInfoTypeName, projectStoredInfoTypeName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationStoredInfoTypeName: return name is OrganizationStoredInfoTypeName;
                case OneofType.ProjectStoredInfoTypeName: return name is ProjectStoredInfoTypeName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="StoredInfoTypeNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public StoredInfoTypeNameOneof(OneofType type, gax::IResourceName name)
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
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="OrganizationStoredInfoTypeName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationStoredInfoTypeName"/>.
        /// </remarks>
        public OrganizationStoredInfoTypeName OrganizationStoredInfoTypeName => CheckAndReturn<OrganizationStoredInfoTypeName>(OneofType.OrganizationStoredInfoTypeName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectStoredInfoTypeName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectStoredInfoTypeName"/>.
        /// </remarks>
        public ProjectStoredInfoTypeName ProjectStoredInfoTypeName => CheckAndReturn<ProjectStoredInfoTypeName>(OneofType.ProjectStoredInfoTypeName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as StoredInfoTypeNameOneof);

        /// <inheritdoc />
        public bool Equals(StoredInfoTypeNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(StoredInfoTypeNameOneof a, StoredInfoTypeNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(StoredInfoTypeNameOneof a, StoredInfoTypeNameOneof b) => !(a == b);
    }


    public partial class CancelDlpJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDlpJobRequest
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

    public partial class CreateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateJobTriggerRequest
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

    public partial class CreateStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeidentifyContentRequest
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

    public partial class DeleteDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDlpJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteJobTriggerRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof StoredInfoTypeNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDlpJobRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetJobTriggerRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof StoredInfoTypeNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InspectContentRequest
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

    public partial class ListDeidentifyTemplatesRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDlpJobsRequest
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

    public partial class ListInspectTemplatesRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListJobTriggersRequest
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

    public partial class ListStoredInfoTypesRequest
    {
        /// <summary>
        /// <see cref="gaxres::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gaxres::OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gaxres::OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RedactImageRequest
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

    public partial class ReidentifyContentRequest
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

    public partial class UpdateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof StoredInfoTypeNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2.StoredInfoTypeNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}