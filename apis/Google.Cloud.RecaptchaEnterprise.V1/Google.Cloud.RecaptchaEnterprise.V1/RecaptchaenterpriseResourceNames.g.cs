// Copyright 2021 Google LLC
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
using gcrv = Google.Cloud.RecaptchaEnterprise.V1;
using sys = System;

namespace Google.Cloud.RecaptchaEnterprise.V1
{
    /// <summary>Resource name for the <c>Assessment</c> resource.</summary>
    public sealed partial class AssessmentName : gax::IResourceName, sys::IEquatable<AssessmentName>
    {
        /// <summary>The possible contents of <see cref="AssessmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/assessments/{assessment}</c>.</summary>
            ProjectAssessment = 1,
        }

        private static gax::PathTemplate s_projectAssessment = new gax::PathTemplate("projects/{project}/assessments/{assessment}");

        /// <summary>Creates a <see cref="AssessmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssessmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssessmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssessmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssessmentName"/> with the pattern <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssessmentName"/> constructed from the provided ids.</returns>
        public static AssessmentName FromProjectAssessment(string projectId, string assessmentId) =>
            new AssessmentName(ResourceNameType.ProjectAssessment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), assessmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </returns>
        public static string Format(string projectId, string assessmentId) => FormatProjectAssessment(projectId, assessmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssessmentName"/> with pattern
        /// <c>projects/{project}/assessments/{assessment}</c>.
        /// </returns>
        public static string FormatProjectAssessment(string projectId, string assessmentId) =>
            s_projectAssessment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssessmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName) => Parse(assessmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssessmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssessmentName"/> if successful.</returns>
        public static AssessmentName Parse(string assessmentName, bool allowUnparsed) =>
            TryParse(assessmentName, allowUnparsed, out AssessmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssessmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssessmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, out AssessmentName result) =>
            TryParse(assessmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssessmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/assessments/{assessment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assessmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssessmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assessmentName, bool allowUnparsed, out AssessmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(assessmentName, nameof(assessmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectAssessment.TryParseName(assessmentName, out resourceName))
            {
                result = FromProjectAssessment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assessmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssessmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assessmentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssessmentId = assessmentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssessmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/assessments/{assessment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assessmentId">The <c>Assessment</c> ID. Must not be <c>null</c> or empty.</param>
        public AssessmentName(string projectId, string assessmentId) : this(ResourceNameType.ProjectAssessment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), assessmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(assessmentId, nameof(assessmentId)))
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
        /// The <c>Assessment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssessmentId { get; }

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
                case ResourceNameType.ProjectAssessment: return s_projectAssessment.Expand(ProjectId, AssessmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
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

    /// <summary>Resource name for the <c>Metrics</c> resource.</summary>
    public sealed partial class MetricsName : gax::IResourceName, sys::IEquatable<MetricsName>
    {
        /// <summary>The possible contents of <see cref="MetricsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/keys/{key}/metrics</c>.</summary>
            ProjectKey = 1,
        }

        private static gax::PathTemplate s_projectKey = new gax::PathTemplate("projects/{project}/keys/{key}/metrics");

        /// <summary>Creates a <see cref="MetricsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetricsName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MetricsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetricsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetricsName"/> with the pattern <c>projects/{project}/keys/{key}/metrics</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricsName"/> constructed from the provided ids.</returns>
        public static MetricsName FromProjectKey(string projectId, string keyId) =>
            new MetricsName(ResourceNameType.ProjectKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricsName"/> with pattern
        /// <c>projects/{project}/keys/{key}/metrics</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricsName"/> with pattern
        /// <c>projects/{project}/keys/{key}/metrics</c>.
        /// </returns>
        public static string Format(string projectId, string keyId) => FormatProjectKey(projectId, keyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricsName"/> with pattern
        /// <c>projects/{project}/keys/{key}/metrics</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricsName"/> with pattern
        /// <c>projects/{project}/keys/{key}/metrics</c>.
        /// </returns>
        public static string FormatProjectKey(string projectId, string keyId) =>
            s_projectKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>Parses the given resource name string into a new <see cref="MetricsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/keys/{key}/metrics</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricsName"/> if successful.</returns>
        public static MetricsName Parse(string metricsName) => Parse(metricsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetricsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/keys/{key}/metrics</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetricsName"/> if successful.</returns>
        public static MetricsName Parse(string metricsName, bool allowUnparsed) =>
            TryParse(metricsName, allowUnparsed, out MetricsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/keys/{key}/metrics</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricsName, out MetricsName result) => TryParse(metricsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/keys/{key}/metrics</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricsName, bool allowUnparsed, out MetricsName result)
        {
            gax::GaxPreconditions.CheckNotNull(metricsName, nameof(metricsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectKey.TryParseName(metricsName, out resourceName))
            {
                result = FromProjectKey(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metricsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetricsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string keyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KeyId = keyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetricsName"/> class from the component parts of pattern
        /// <c>projects/{project}/keys/{key}/metrics</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        public MetricsName(string projectId, string keyId) : this(ResourceNameType.ProjectKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)))
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
        /// The <c>Key</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyId { get; }

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
                case ResourceNameType.ProjectKey: return s_projectKey.Expand(ProjectId, KeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetricsName);

        /// <inheritdoc/>
        public bool Equals(MetricsName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MetricsName a, MetricsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MetricsName a, MetricsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Key</c> resource.</summary>
    public sealed partial class KeyName : gax::IResourceName, sys::IEquatable<KeyName>
    {
        /// <summary>The possible contents of <see cref="KeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/keys/{key}</c>.</summary>
            ProjectKey = 1,
        }

        private static gax::PathTemplate s_projectKey = new gax::PathTemplate("projects/{project}/keys/{key}");

        /// <summary>Creates a <see cref="KeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="KeyName"/> with the pattern <c>projects/{project}/keys/{key}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KeyName"/> constructed from the provided ids.</returns>
        public static KeyName FromProjectKey(string projectId, string keyId) =>
            new KeyName(ResourceNameType.ProjectKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeyName"/> with pattern
        /// <c>projects/{project}/keys/{key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeyName"/> with pattern <c>projects/{project}/keys/{key}</c>.
        /// </returns>
        public static string Format(string projectId, string keyId) => FormatProjectKey(projectId, keyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeyName"/> with pattern
        /// <c>projects/{project}/keys/{key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeyName"/> with pattern <c>projects/{project}/keys/{key}</c>.
        /// </returns>
        public static string FormatProjectKey(string projectId, string keyId) =>
            s_projectKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>Parses the given resource name string into a new <see cref="KeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/keys/{key}</c></description></item></list>
        /// </remarks>
        /// <param name="keyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeyName"/> if successful.</returns>
        public static KeyName Parse(string keyName) => Parse(keyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/keys/{key}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeyName"/> if successful.</returns>
        public static KeyName Parse(string keyName, bool allowUnparsed) =>
            TryParse(keyName, allowUnparsed, out KeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="KeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/keys/{key}</c></description></item></list>
        /// </remarks>
        /// <param name="keyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyName, out KeyName result) => TryParse(keyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/keys/{key}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keyName, bool allowUnparsed, out KeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(keyName, nameof(keyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectKey.TryParseName(keyName, out resourceName))
            {
                result = FromProjectKey(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string keyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KeyId = keyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeyName"/> class from the component parts of pattern
        /// <c>projects/{project}/keys/{key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        public KeyName(string projectId, string keyId) : this(ResourceNameType.ProjectKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)))
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
        /// The <c>Key</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyId { get; }

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
                case ResourceNameType.ProjectKey: return s_projectKey.Expand(ProjectId, KeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
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
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AssessmentName.Parse(Name, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MigrateKeyRequest
    {
        /// <summary>
        /// <see cref="gcrv::KeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::KeyName KeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMetricsRequest
    {
        /// <summary>
        /// <see cref="gcrv::MetricsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::MetricsName MetricsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::MetricsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Metrics
    {
        /// <summary>
        /// <see cref="gcrv::MetricsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::MetricsName MetricsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::MetricsName.Parse(Name, allowUnparsed: true);
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
            get => string.IsNullOrEmpty(Name) ? null : gcrv::KeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
