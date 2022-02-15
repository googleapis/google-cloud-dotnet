// Copyright 2022 Google LLC
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
using gcdv = Google.Cloud.DataLabeling.V1Beta1;
using sys = System;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    /// <summary>Resource name for the <c>EvaluationJob</c> resource.</summary>
    public sealed partial class EvaluationJobName : gax::IResourceName, sys::IEquatable<EvaluationJobName>
    {
        /// <summary>The possible contents of <see cref="EvaluationJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
            /// </summary>
            ProjectEvaluationJob = 1,
        }

        private static gax::PathTemplate s_projectEvaluationJob = new gax::PathTemplate("projects/{project}/evaluationJobs/{evaluation_job}");

        /// <summary>Creates a <see cref="EvaluationJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationJobName"/> with the pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationJobId">The <c>EvaluationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EvaluationJobName"/> constructed from the provided ids.</returns>
        public static EvaluationJobName FromProjectEvaluationJob(string projectId, string evaluationJobId) =>
            new EvaluationJobName(ResourceNameType.ProjectEvaluationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), evaluationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationJobId, nameof(evaluationJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationJobName"/> with pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationJobId">The <c>EvaluationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationJobName"/> with pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
        /// </returns>
        public static string Format(string projectId, string evaluationJobId) =>
            FormatProjectEvaluationJob(projectId, evaluationJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationJobName"/> with pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationJobId">The <c>EvaluationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationJobName"/> with pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>.
        /// </returns>
        public static string FormatProjectEvaluationJob(string projectId, string evaluationJobId) =>
            s_projectEvaluationJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationJobId, nameof(evaluationJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/evaluationJobs/{evaluation_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationJobName"/> if successful.</returns>
        public static EvaluationJobName Parse(string evaluationJobName) => Parse(evaluationJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/evaluationJobs/{evaluation_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationJobName"/> if successful.</returns>
        public static EvaluationJobName Parse(string evaluationJobName, bool allowUnparsed) =>
            TryParse(evaluationJobName, allowUnparsed, out EvaluationJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/evaluationJobs/{evaluation_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationJobName, out EvaluationJobName result) =>
            TryParse(evaluationJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/evaluationJobs/{evaluation_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationJobName, bool allowUnparsed, out EvaluationJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationJobName, nameof(evaluationJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectEvaluationJob.TryParseName(evaluationJobName, out resourceName))
            {
                result = FromProjectEvaluationJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string evaluationJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EvaluationJobId = evaluationJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/evaluationJobs/{evaluation_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationJobId">The <c>EvaluationJob</c> ID. Must not be <c>null</c> or empty.</param>
        public EvaluationJobName(string projectId, string evaluationJobId) : this(ResourceNameType.ProjectEvaluationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), evaluationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationJobId, nameof(evaluationJobId)))
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
        /// The <c>EvaluationJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EvaluationJobId { get; }

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
                case ResourceNameType.ProjectEvaluationJob: return s_projectEvaluationJob.Expand(ProjectId, EvaluationJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationJobName);

        /// <inheritdoc/>
        public bool Equals(EvaluationJobName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(EvaluationJobName a, EvaluationJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(EvaluationJobName a, EvaluationJobName b) => !(a == b);
    }

    public partial class EvaluationJob
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationJobName EvaluationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
