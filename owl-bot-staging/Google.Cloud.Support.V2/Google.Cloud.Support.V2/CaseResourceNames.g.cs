// Copyright 2025 Google LLC
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
using gcsv = Google.Cloud.Support.V2;
using sys = System;

namespace Google.Cloud.Support.V2
{
    /// <summary>Resource name for the <c>Case</c> resource.</summary>
    public sealed partial class CaseName : gax::IResourceName, sys::IEquatable<CaseName>
    {
        /// <summary>The possible contents of <see cref="CaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>organizations/{organization}/cases/{case}</c>.</summary>
            OrganizationCase = 1,

            /// <summary>A resource name with pattern <c>projects/{project}/cases/{case}</c>.</summary>
            ProjectCase = 2,
        }

        private static gax::PathTemplate s_organizationCase = new gax::PathTemplate("organizations/{organization}/cases/{case}");

        private static gax::PathTemplate s_projectCase = new gax::PathTemplate("projects/{project}/cases/{case}");

        /// <summary>Creates a <see cref="CaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CaseName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CaseName"/> with the pattern <c>organizations/{organization}/cases/{case}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CaseName"/> constructed from the provided ids.</returns>
        public static CaseName FromOrganizationCase(string organizationId, string caseId) =>
            new CaseName(ResourceNameType.OrganizationCase, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)));

        /// <summary>Creates a <see cref="CaseName"/> with the pattern <c>projects/{project}/cases/{case}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CaseName"/> constructed from the provided ids.</returns>
        public static CaseName FromProjectCase(string projectId, string caseId) =>
            new CaseName(ResourceNameType.ProjectCase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaseName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaseName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}</c>.
        /// </returns>
        public static string Format(string organizationId, string caseId) => FormatOrganizationCase(organizationId, caseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaseName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaseName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}</c>.
        /// </returns>
        public static string FormatOrganizationCase(string organizationId, string caseId) =>
            s_organizationCase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaseName"/> with pattern
        /// <c>projects/{project}/cases/{case}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaseName"/> with pattern <c>projects/{project}/cases/{case}</c>
        /// .
        /// </returns>
        public static string FormatProjectCase(string projectId, string caseId) =>
            s_projectCase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)));

        /// <summary>Parses the given resource name string into a new <see cref="CaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CaseName"/> if successful.</returns>
        public static CaseName Parse(string caseName) => Parse(caseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CaseName"/> if successful.</returns>
        public static CaseName Parse(string caseName, bool allowUnparsed) =>
            TryParse(caseName, allowUnparsed, out CaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="CaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caseName, out CaseName result) => TryParse(caseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caseName, bool allowUnparsed, out CaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(caseName, nameof(caseName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationCase.TryParseName(caseName, out resourceName))
            {
                result = FromOrganizationCase(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectCase.TryParseName(caseName, out resourceName))
            {
                result = FromProjectCase(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(caseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caseId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaseId = caseId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CaseName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/cases/{case}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        public CaseName(string organizationId, string caseId) : this(ResourceNameType.OrganizationCase, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)))
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
        /// The <c>Case</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string CaseId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.OrganizationCase: return s_organizationCase.Expand(OrganizationId, CaseId);
                case ResourceNameType.ProjectCase: return s_projectCase.Expand(ProjectId, CaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CaseName);

        /// <inheritdoc/>
        public bool Equals(CaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CaseName a, CaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CaseName a, CaseName b) => !(a == b);
    }

    public partial class Case
    {
        /// <summary>
        /// <see cref="gcsv::CaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::CaseName CaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::CaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
