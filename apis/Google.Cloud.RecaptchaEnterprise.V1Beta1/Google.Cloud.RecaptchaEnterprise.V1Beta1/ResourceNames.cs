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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1
{
    /// <summary>
    /// Resource name for the 'assessment' resource.
    /// </summary>
    public sealed partial class AssessmentName : gax::IResourceName, sys::IEquatable<AssessmentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/assessments/{assessment}");

        /// <summary>
        /// Parses the given assessment resource name in string form into a new
        /// <see cref="AssessmentName"/> instance.
        /// </summary>
        /// <param name="assessmentName">The assessment resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assessmentName);
            return new AssessmentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given assessment resource name in string form into a new
        /// <see cref="AssessmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assessmentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assessmentName">The assessment resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AssessmentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, out AssessmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(assessmentName, out resourceName))
            {
                result = new AssessmentName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AssessmentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="assessmentId">The assessment ID. Must not be <c>null</c>.</param>
        public AssessmentName(string projectId, string assessmentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            AssessmentId = gax::GaxPreconditions.CheckNotNull(assessmentId, nameof(assessmentId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The assessment ID. Never <c>null</c>.
        /// </summary>
        public string AssessmentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, AssessmentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AssessmentName);

        /// <inheritdoc />
        public bool Equals(AssessmentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AssessmentName a, AssessmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AssessmentName a, AssessmentName b) => !(a == b);
    }



}