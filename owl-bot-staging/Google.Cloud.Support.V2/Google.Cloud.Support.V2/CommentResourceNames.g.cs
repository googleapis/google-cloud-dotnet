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
    /// <summary>Resource name for the <c>Comment</c> resource.</summary>
    public sealed partial class CommentName : gax::IResourceName, sys::IEquatable<CommentName>
    {
        /// <summary>The possible contents of <see cref="CommentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
            /// </summary>
            OrganizationCaseComment = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/cases/{case}/comments/{comment}</c>.
            /// </summary>
            ProjectCaseComment = 2,
        }

        private static gax::PathTemplate s_organizationCaseComment = new gax::PathTemplate("organizations/{organization}/cases/{case}/comments/{comment}");

        private static gax::PathTemplate s_projectCaseComment = new gax::PathTemplate("projects/{project}/cases/{case}/comments/{comment}");

        /// <summary>Creates a <see cref="CommentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CommentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CommentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CommentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CommentName"/> with the pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CommentName"/> constructed from the provided ids.</returns>
        public static CommentName FromOrganizationCaseComment(string organizationId, string caseId, string commentId) =>
            new CommentName(ResourceNameType.OrganizationCaseComment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Creates a <see cref="CommentName"/> with the pattern <c>projects/{project}/cases/{case}/comments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CommentName"/> constructed from the provided ids.</returns>
        public static CommentName FromProjectCaseComment(string projectId, string caseId, string commentId) =>
            new CommentName(ResourceNameType.ProjectCaseComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CommentName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CommentName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
        /// </returns>
        public static string Format(string organizationId, string caseId, string commentId) =>
            FormatOrganizationCaseComment(organizationId, caseId, commentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CommentName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CommentName"/> with pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>.
        /// </returns>
        public static string FormatOrganizationCaseComment(string organizationId, string caseId, string commentId) =>
            s_organizationCaseComment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/cases/{case}/comments/{comment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CommentName"/> with pattern
        /// <c>projects/{project}/cases/{case}/comments/{comment}</c>.
        /// </returns>
        public static string FormatProjectCaseComment(string projectId, string caseId, string commentId) =>
            s_projectCaseComment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>Parses the given resource name string into a new <see cref="CommentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}/comments/{comment}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}/comments/{comment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CommentName"/> if successful.</returns>
        public static CommentName Parse(string commentName) => Parse(commentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CommentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}/comments/{comment}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}/comments/{comment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CommentName"/> if successful.</returns>
        public static CommentName Parse(string commentName, bool allowUnparsed) =>
            TryParse(commentName, allowUnparsed, out CommentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CommentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}/comments/{comment}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}/comments/{comment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string commentName, out CommentName result) => TryParse(commentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CommentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/cases/{case}/comments/{comment}</c></description></item>
        /// <item><description><c>projects/{project}/cases/{case}/comments/{comment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="commentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string commentName, bool allowUnparsed, out CommentName result)
        {
            gax::GaxPreconditions.CheckNotNull(commentName, nameof(commentName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationCaseComment.TryParseName(commentName, out resourceName))
            {
                result = FromOrganizationCaseComment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectCaseComment.TryParseName(commentName, out resourceName))
            {
                result = FromProjectCaseComment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(commentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CommentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caseId = null, string commentId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaseId = caseId;
            CommentId = commentId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CommentName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/cases/{case}/comments/{comment}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caseId">The <c>Case</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        public CommentName(string organizationId, string caseId, string commentId) : this(ResourceNameType.OrganizationCaseComment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), caseId: gax::GaxPreconditions.CheckNotNullOrEmpty(caseId, nameof(caseId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)))
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
        /// The <c>Comment</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string CommentId { get; }

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
                case ResourceNameType.OrganizationCaseComment: return s_organizationCaseComment.Expand(OrganizationId, CaseId, CommentId);
                case ResourceNameType.ProjectCaseComment: return s_projectCaseComment.Expand(ProjectId, CaseId, CommentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CommentName);

        /// <inheritdoc/>
        public bool Equals(CommentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CommentName a, CommentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CommentName a, CommentName b) => !(a == b);
    }

    public partial class Comment
    {
        /// <summary>
        /// <see cref="gcsv::CommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::CommentName CommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::CommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
