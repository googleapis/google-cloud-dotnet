// Copyright 2024 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssessmentName a, AssessmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MetricsName a, MetricsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(KeyName a, KeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(KeyName a, KeyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FirewallPolicy</c> resource.</summary>
    public sealed partial class FirewallPolicyName : gax::IResourceName, sys::IEquatable<FirewallPolicyName>
    {
        /// <summary>The possible contents of <see cref="FirewallPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
            /// </summary>
            ProjectFirewallpolicy = 1,
        }

        private static gax::PathTemplate s_projectFirewallpolicy = new gax::PathTemplate("projects/{project}/firewallpolicies/{firewallpolicy}");

        /// <summary>Creates a <see cref="FirewallPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FirewallPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FirewallPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FirewallPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FirewallPolicyName"/> with the pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallpolicyId">The <c>Firewallpolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FirewallPolicyName"/> constructed from the provided ids.</returns>
        public static FirewallPolicyName FromProjectFirewallpolicy(string projectId, string firewallpolicyId) =>
            new FirewallPolicyName(ResourceNameType.ProjectFirewallpolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), firewallpolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallpolicyId, nameof(firewallpolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallPolicyName"/> with pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallpolicyId">The <c>Firewallpolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirewallPolicyName"/> with pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
        /// </returns>
        public static string Format(string projectId, string firewallpolicyId) =>
            FormatProjectFirewallpolicy(projectId, firewallpolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallPolicyName"/> with pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallpolicyId">The <c>Firewallpolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirewallPolicyName"/> with pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>.
        /// </returns>
        public static string FormatProjectFirewallpolicy(string projectId, string firewallpolicyId) =>
            s_projectFirewallpolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(firewallpolicyId, nameof(firewallpolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/firewallpolicies/{firewallpolicy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="firewallPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FirewallPolicyName"/> if successful.</returns>
        public static FirewallPolicyName Parse(string firewallPolicyName) => Parse(firewallPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/firewallpolicies/{firewallpolicy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FirewallPolicyName"/> if successful.</returns>
        public static FirewallPolicyName Parse(string firewallPolicyName, bool allowUnparsed) =>
            TryParse(firewallPolicyName, allowUnparsed, out FirewallPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/firewallpolicies/{firewallpolicy}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="firewallPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallPolicyName, out FirewallPolicyName result) =>
            TryParse(firewallPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/firewallpolicies/{firewallpolicy}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallPolicyName, bool allowUnparsed, out FirewallPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(firewallPolicyName, nameof(firewallPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectFirewallpolicy.TryParseName(firewallPolicyName, out resourceName))
            {
                result = FromProjectFirewallpolicy(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(firewallPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FirewallPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string firewallpolicyId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FirewallpolicyId = firewallpolicyId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FirewallPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/firewallpolicies/{firewallpolicy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallpolicyId">The <c>Firewallpolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public FirewallPolicyName(string projectId, string firewallpolicyId) : this(ResourceNameType.ProjectFirewallpolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), firewallpolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallpolicyId, nameof(firewallpolicyId)))
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
        /// The <c>Firewallpolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FirewallpolicyId { get; }

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
                case ResourceNameType.ProjectFirewallpolicy: return s_projectFirewallpolicy.Expand(ProjectId, FirewallpolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FirewallPolicyName);

        /// <inheritdoc/>
        public bool Equals(FirewallPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FirewallPolicyName a, FirewallPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FirewallPolicyName a, FirewallPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RelatedAccountGroupMembership</c> resource.</summary>
    public sealed partial class RelatedAccountGroupMembershipName : gax::IResourceName, sys::IEquatable<RelatedAccountGroupMembershipName>
    {
        /// <summary>The possible contents of <see cref="RelatedAccountGroupMembershipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
            /// </summary>
            ProjectRelatedaccountgroupMembership = 1,
        }

        private static gax::PathTemplate s_projectRelatedaccountgroupMembership = new gax::PathTemplate("projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}");

        /// <summary>
        /// Creates a <see cref="RelatedAccountGroupMembershipName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RelatedAccountGroupMembershipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RelatedAccountGroupMembershipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RelatedAccountGroupMembershipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RelatedAccountGroupMembershipName"/> with the pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="RelatedAccountGroupMembershipName"/> constructed from the provided ids.
        /// </returns>
        public static RelatedAccountGroupMembershipName FromProjectRelatedaccountgroupMembership(string projectId, string relatedaccountgroupId, string membershipId) =>
            new RelatedAccountGroupMembershipName(ResourceNameType.ProjectRelatedaccountgroupMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), relatedaccountgroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RelatedAccountGroupMembershipName"/> with
        /// pattern <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RelatedAccountGroupMembershipName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
        /// </returns>
        public static string Format(string projectId, string relatedaccountgroupId, string membershipId) =>
            FormatProjectRelatedaccountgroupMembership(projectId, relatedaccountgroupId, membershipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RelatedAccountGroupMembershipName"/> with
        /// pattern <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RelatedAccountGroupMembershipName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>.
        /// </returns>
        public static string FormatProjectRelatedaccountgroupMembership(string projectId, string relatedaccountgroupId, string membershipId) =>
            s_projectRelatedaccountgroupMembership.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RelatedAccountGroupMembershipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="relatedAccountGroupMembershipName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="RelatedAccountGroupMembershipName"/> if successful.</returns>
        public static RelatedAccountGroupMembershipName Parse(string relatedAccountGroupMembershipName) =>
            Parse(relatedAccountGroupMembershipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RelatedAccountGroupMembershipName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="relatedAccountGroupMembershipName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RelatedAccountGroupMembershipName"/> if successful.</returns>
        public static RelatedAccountGroupMembershipName Parse(string relatedAccountGroupMembershipName, bool allowUnparsed) =>
            TryParse(relatedAccountGroupMembershipName, allowUnparsed, out RelatedAccountGroupMembershipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RelatedAccountGroupMembershipName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="relatedAccountGroupMembershipName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RelatedAccountGroupMembershipName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string relatedAccountGroupMembershipName, out RelatedAccountGroupMembershipName result) =>
            TryParse(relatedAccountGroupMembershipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RelatedAccountGroupMembershipName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="relatedAccountGroupMembershipName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RelatedAccountGroupMembershipName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string relatedAccountGroupMembershipName, bool allowUnparsed, out RelatedAccountGroupMembershipName result)
        {
            gax::GaxPreconditions.CheckNotNull(relatedAccountGroupMembershipName, nameof(relatedAccountGroupMembershipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRelatedaccountgroupMembership.TryParseName(relatedAccountGroupMembershipName, out resourceName))
            {
                result = FromProjectRelatedaccountgroupMembership(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(relatedAccountGroupMembershipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RelatedAccountGroupMembershipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string membershipId = null, string projectId = null, string relatedaccountgroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MembershipId = membershipId;
            ProjectId = projectId;
            RelatedaccountgroupId = relatedaccountgroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RelatedAccountGroupMembershipName"/> class from the component
        /// parts of pattern <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}/memberships/{membership}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        public RelatedAccountGroupMembershipName(string projectId, string relatedaccountgroupId, string membershipId) : this(ResourceNameType.ProjectRelatedaccountgroupMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), relatedaccountgroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)))
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
        /// The <c>Membership</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MembershipId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Relatedaccountgroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RelatedaccountgroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRelatedaccountgroupMembership: return s_projectRelatedaccountgroupMembership.Expand(ProjectId, RelatedaccountgroupId, MembershipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RelatedAccountGroupMembershipName);

        /// <inheritdoc/>
        public bool Equals(RelatedAccountGroupMembershipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RelatedAccountGroupMembershipName a, RelatedAccountGroupMembershipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RelatedAccountGroupMembershipName a, RelatedAccountGroupMembershipName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RelatedAccountGroup</c> resource.</summary>
    public sealed partial class RelatedAccountGroupName : gax::IResourceName, sys::IEquatable<RelatedAccountGroupName>
    {
        /// <summary>The possible contents of <see cref="RelatedAccountGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
            /// </summary>
            ProjectRelatedaccountgroup = 1,
        }

        private static gax::PathTemplate s_projectRelatedaccountgroup = new gax::PathTemplate("projects/{project}/relatedaccountgroups/{relatedaccountgroup}");

        /// <summary>Creates a <see cref="RelatedAccountGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RelatedAccountGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RelatedAccountGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RelatedAccountGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RelatedAccountGroupName"/> with the pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="RelatedAccountGroupName"/> constructed from the provided ids.
        /// </returns>
        public static RelatedAccountGroupName FromProjectRelatedaccountgroup(string projectId, string relatedaccountgroupId) =>
            new RelatedAccountGroupName(ResourceNameType.ProjectRelatedaccountgroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), relatedaccountgroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RelatedAccountGroupName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RelatedAccountGroupName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
        /// </returns>
        public static string Format(string projectId, string relatedaccountgroupId) =>
            FormatProjectRelatedaccountgroup(projectId, relatedaccountgroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RelatedAccountGroupName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RelatedAccountGroupName"/> with pattern
        /// <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>.
        /// </returns>
        public static string FormatProjectRelatedaccountgroup(string projectId, string relatedaccountgroupId) =>
            s_projectRelatedaccountgroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RelatedAccountGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="relatedAccountGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RelatedAccountGroupName"/> if successful.</returns>
        public static RelatedAccountGroupName Parse(string relatedAccountGroupName) => Parse(relatedAccountGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RelatedAccountGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="relatedAccountGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RelatedAccountGroupName"/> if successful.</returns>
        public static RelatedAccountGroupName Parse(string relatedAccountGroupName, bool allowUnparsed) =>
            TryParse(relatedAccountGroupName, allowUnparsed, out RelatedAccountGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RelatedAccountGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="relatedAccountGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RelatedAccountGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string relatedAccountGroupName, out RelatedAccountGroupName result) =>
            TryParse(relatedAccountGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RelatedAccountGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="relatedAccountGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RelatedAccountGroupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string relatedAccountGroupName, bool allowUnparsed, out RelatedAccountGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(relatedAccountGroupName, nameof(relatedAccountGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRelatedaccountgroup.TryParseName(relatedAccountGroupName, out resourceName))
            {
                result = FromProjectRelatedaccountgroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(relatedAccountGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RelatedAccountGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string relatedaccountgroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RelatedaccountgroupId = relatedaccountgroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RelatedAccountGroupName"/> class from the component parts of
        /// pattern <c>projects/{project}/relatedaccountgroups/{relatedaccountgroup}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="relatedaccountgroupId">
        /// The <c>Relatedaccountgroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public RelatedAccountGroupName(string projectId, string relatedaccountgroupId) : this(ResourceNameType.ProjectRelatedaccountgroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), relatedaccountgroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(relatedaccountgroupId, nameof(relatedaccountgroupId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Relatedaccountgroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RelatedaccountgroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRelatedaccountgroup: return s_projectRelatedaccountgroup.Expand(ProjectId, RelatedaccountgroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RelatedAccountGroupName);

        /// <inheritdoc/>
        public bool Equals(RelatedAccountGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RelatedAccountGroupName a, RelatedAccountGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RelatedAccountGroupName a, RelatedAccountGroupName b) => !(a == b);
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

    public partial class RetrieveLegacySecretKeyRequest
    {
        /// <summary><see cref="KeyName"/>-typed view over the <see cref="Key"/> resource name property.</summary>
        public KeyName KeyAsKeyName
        {
            get => string.IsNullOrEmpty(Key) ? null : KeyName.Parse(Key, allowUnparsed: true);
            set => Key = value?.ToString() ?? "";
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

    public partial class CreateFirewallPolicyRequest
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

    public partial class ListFirewallPoliciesRequest
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

    public partial class GetFirewallPolicyRequest
    {
        /// <summary>
        /// <see cref="gcrv::FirewallPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::FirewallPolicyName FirewallPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::FirewallPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFirewallPolicyRequest
    {
        /// <summary>
        /// <see cref="gcrv::FirewallPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::FirewallPolicyName FirewallPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::FirewallPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReorderFirewallPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FirewallPolicyName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<FirewallPolicyName> FirewallPolicyNames
        {
            get => new gax::ResourceNameList<FirewallPolicyName>(Names, s => string.IsNullOrEmpty(s) ? null : FirewallPolicyName.Parse(s, allowUnparsed: true));
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

    public partial class FirewallPolicy
    {
        /// <summary>
        /// <see cref="gcrv::FirewallPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::FirewallPolicyName FirewallPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::FirewallPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRelatedAccountGroupMembershipsRequest
    {
        /// <summary>
        /// <see cref="RelatedAccountGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RelatedAccountGroupName ParentAsRelatedAccountGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RelatedAccountGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListRelatedAccountGroupsRequest
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

    public partial class SearchRelatedAccountGroupMembershipsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class AddIpOverrideRequest
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

    public partial class RemoveIpOverrideRequest
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

    public partial class ListIpOverridesRequest
    {
        /// <summary><see cref="KeyName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public KeyName ParentAsKeyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KeyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RelatedAccountGroupMembership
    {
        /// <summary>
        /// <see cref="gcrv::RelatedAccountGroupMembershipName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcrv::RelatedAccountGroupMembershipName RelatedAccountGroupMembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RelatedAccountGroupMembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RelatedAccountGroup
    {
        /// <summary>
        /// <see cref="gcrv::RelatedAccountGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RelatedAccountGroupName RelatedAccountGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RelatedAccountGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
