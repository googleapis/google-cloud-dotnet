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
using gagr = Google.Api.Gax.ResourceNames;
using gcrv = Google.Cloud.RecaptchaEnterprise.V1Beta1;
using sys = System;

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1
{
    /// <summary>Resource name for the <c>Assessment</c> resource.</summary>
    public sealed partial class AssessmentName : gax::IResourceName, sys::IEquatable<AssessmentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/assessments/{assessment}");

        /// <summary>
        /// Parses the given <c>Assessment</c> resource name in string form into a new <see cref="AssessmentName"/>
        /// instance.
        /// </summary>
        /// <param name="assessmentName">
        /// The <c>Assessment</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assessmentName);
            return new AssessmentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="AssessmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assessmentName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assessmentName">
        /// The <c>Assessment</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssessmentName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, out AssessmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            if (s_template.TryParseName(assessmentName, out gax::TemplatedResourceName resourceName))
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

        /// <summary>Formats the IDs into the string representation of the <see cref="AssessmentName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AssessmentName"/>.</returns>
        public static string Format(string projectId, string assessmentId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(assessmentId, nameof(assessmentId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AssessmentName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c>.</param>
        public AssessmentName(string projectId, string assessmentId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            AssessmentId = gax::GaxPreconditions.CheckNotNull(assessmentId, nameof(assessmentId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Assessment</c> ID. Never <c>null</c>.</summary>
        public string AssessmentId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, AssessmentId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssessmentName);

        /// <inheritdoc/>
        public bool Equals(AssessmentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssessmentName a, AssessmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssessmentName a, AssessmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Key</c> resource.</summary>
    public sealed partial class KeyName : gax::IResourceName, sys::IEquatable<KeyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/keys/{key}");

        /// <summary>
        /// Parses the given <c>Key</c> resource name in string form into a new <see cref="KeyName"/> instance.
        /// </summary>
        /// <param name="keyName">The <c>Key</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeyName"/> if successful.</returns>
        public static KeyName Parse(string keyName)
        {
            gax::GaxPreconditions.CheckNotNull(keyName, nameof(keyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keyName);
            return new KeyName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="KeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keyName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keyName">The <c>Key</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeyName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyName, out KeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(keyName, nameof(keyName));
            if (s_template.TryParseName(keyName, out gax::TemplatedResourceName resourceName))
            {
                result = new KeyName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="KeyName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="KeyName"/>.</returns>
        public static string Format(string projectId, string keyId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(keyId, nameof(keyId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="KeyName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c>.</param>
        public KeyName(string projectId, string keyId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            KeyId = gax::GaxPreconditions.CheckNotNull(keyId, nameof(keyId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Key</c> ID. Never <c>null</c>.</summary>
        public string KeyId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, KeyId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeyName);

        /// <inheritdoc/>
        public bool Equals(KeyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeyName a, KeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeyName a, KeyName b) => !(a == b);
    }

    public partial class CreateAssessmentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AnnotateAssessmentRequest
    {
        /// <summary>
        /// <see cref="gcrv::AssessmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AssessmentName AssessmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Assessment
    {
        /// <summary>
        /// <see cref="gcrv::AssessmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AssessmentName AssessmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateKeyRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListKeysRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::KeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::KeyName KeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::KeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::KeyName KeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Key
    {
        /// <summary>
        /// <see cref="gcrv::KeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::KeyName KeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
