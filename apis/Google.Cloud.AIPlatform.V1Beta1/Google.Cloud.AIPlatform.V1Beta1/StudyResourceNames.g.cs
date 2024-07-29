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
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Study</c> resource.</summary>
    public sealed partial class StudyName : gax::IResourceName, sys::IEquatable<StudyName>
    {
        /// <summary>The possible contents of <see cref="StudyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/studies/{study}</c>.
            /// </summary>
            ProjectLocationStudy = 1,
        }

        private static gax::PathTemplate s_projectLocationStudy = new gax::PathTemplate("projects/{project}/locations/{location}/studies/{study}");

        /// <summary>Creates a <see cref="StudyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StudyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StudyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StudyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StudyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StudyName"/> constructed from the provided ids.</returns>
        public static StudyName FromProjectLocationStudy(string projectId, string locationId, string studyId) =>
            new StudyName(ResourceNameType.ProjectLocationStudy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), studyId: gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StudyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StudyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string studyId) =>
            FormatProjectLocationStudy(projectId, locationId, studyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StudyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StudyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>.
        /// </returns>
        public static string FormatProjectLocationStudy(string projectId, string locationId, string studyId) =>
            s_projectLocationStudy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)));

        /// <summary>Parses the given resource name string into a new <see cref="StudyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/studies/{study}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="studyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StudyName"/> if successful.</returns>
        public static StudyName Parse(string studyName) => Parse(studyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StudyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/studies/{study}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="studyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StudyName"/> if successful.</returns>
        public static StudyName Parse(string studyName, bool allowUnparsed) =>
            TryParse(studyName, allowUnparsed, out StudyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StudyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/studies/{study}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="studyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StudyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string studyName, out StudyName result) => TryParse(studyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StudyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/studies/{study}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="studyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StudyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string studyName, bool allowUnparsed, out StudyName result)
        {
            gax::GaxPreconditions.CheckNotNull(studyName, nameof(studyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStudy.TryParseName(studyName, out resourceName))
            {
                result = FromProjectLocationStudy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(studyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StudyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string studyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            StudyId = studyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StudyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        public StudyName(string projectId, string locationId, string studyId) : this(ResourceNameType.ProjectLocationStudy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), studyId: gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Study</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StudyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStudy: return s_projectLocationStudy.Expand(ProjectId, LocationId, StudyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StudyName);

        /// <inheritdoc/>
        public bool Equals(StudyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StudyName a, StudyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StudyName a, StudyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Trial</c> resource.</summary>
    public sealed partial class TrialName : gax::IResourceName, sys::IEquatable<TrialName>
    {
        /// <summary>The possible contents of <see cref="TrialName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>
            /// .
            /// </summary>
            ProjectLocationStudyTrial = 1,
        }

        private static gax::PathTemplate s_projectLocationStudyTrial = new gax::PathTemplate("projects/{project}/locations/{location}/studies/{study}/trials/{trial}");

        /// <summary>Creates a <see cref="TrialName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TrialName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TrialName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TrialName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TrialName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TrialName"/> constructed from the provided ids.</returns>
        public static TrialName FromProjectLocationStudyTrial(string projectId, string locationId, string studyId, string trialId) =>
            new TrialName(ResourceNameType.ProjectLocationStudyTrial, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), studyId: gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrialName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TrialName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string studyId, string trialId) =>
            FormatProjectLocationStudyTrial(projectId, locationId, studyId, trialId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TrialName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TrialName"/> with pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>.
        /// </returns>
        public static string FormatProjectLocationStudyTrial(string projectId, string locationId, string studyId, string trialId) =>
            s_projectLocationStudyTrial.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)));

        /// <summary>Parses the given resource name string into a new <see cref="TrialName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trialName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TrialName"/> if successful.</returns>
        public static TrialName Parse(string trialName) => Parse(trialName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TrialName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trialName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TrialName"/> if successful.</returns>
        public static TrialName Parse(string trialName, bool allowUnparsed) =>
            TryParse(trialName, allowUnparsed, out TrialName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrialName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="trialName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrialName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trialName, out TrialName result) => TryParse(trialName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TrialName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="trialName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TrialName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string trialName, bool allowUnparsed, out TrialName result)
        {
            gax::GaxPreconditions.CheckNotNull(trialName, nameof(trialName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationStudyTrial.TryParseName(trialName, out resourceName))
            {
                result = FromProjectLocationStudyTrial(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(trialName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TrialName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string studyId = null, string trialId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            StudyId = studyId;
            TrialId = trialId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TrialName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/studies/{study}/trials/{trial}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="studyId">The <c>Study</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        public TrialName(string projectId, string locationId, string studyId, string trialId) : this(ResourceNameType.ProjectLocationStudyTrial, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), studyId: gax::GaxPreconditions.CheckNotNullOrEmpty(studyId, nameof(studyId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Study</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StudyId { get; }

        /// <summary>
        /// The <c>Trial</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TrialId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationStudyTrial: return s_projectLocationStudyTrial.Expand(ProjectId, LocationId, StudyId, TrialId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TrialName);

        /// <inheritdoc/>
        public bool Equals(TrialName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TrialName a, TrialName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TrialName a, TrialName b) => !(a == b);
    }

    public partial class Study
    {
        /// <summary>
        /// <see cref="gcav::StudyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::StudyName StudyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::StudyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Trial
    {
        /// <summary>
        /// <see cref="gcav::TrialName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrialName TrialName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrialName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomJobName"/>-typed view over the <see cref="CustomJob"/> resource name property.
        /// </summary>
        public CustomJobName CustomJobAsCustomJobName
        {
            get => string.IsNullOrEmpty(CustomJob) ? null : CustomJobName.Parse(CustomJob, allowUnparsed: true);
            set => CustomJob = value?.ToString() ?? "";
        }
    }
}
