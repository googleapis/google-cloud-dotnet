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
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Template</c> resource.</summary>
    public sealed partial class TemplateName : gax::IResourceName, sys::IEquatable<TemplateName>
    {
        /// <summary>The possible contents of <see cref="TemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/templates/{template}</c>.
            /// </summary>
            ProjectLocationTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/templates/{template}");

        /// <summary>Creates a <see cref="TemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TemplateName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TemplateName"/> constructed from the provided ids.</returns>
        public static TemplateName FromProjectLocationTemplate(string projectId, string locationId, string templateId) =>
            new TemplateName(ResourceNameType.ProjectLocationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), templateId: gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string templateId) =>
            FormatProjectLocationTemplate(projectId, locationId, templateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </returns>
        public static string FormatProjectLocationTemplate(string projectId, string locationId, string templateId) =>
            s_projectLocationTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)));

        /// <summary>Parses the given resource name string into a new <see cref="TemplateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TemplateName"/> if successful.</returns>
        public static TemplateName Parse(string templateName) => Parse(templateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TemplateName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TemplateName"/> if successful.</returns>
        public static TemplateName Parse(string templateName, bool allowUnparsed) =>
            TryParse(templateName, allowUnparsed, out TemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string templateName, out TemplateName result) => TryParse(templateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string templateName, bool allowUnparsed, out TemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(templateName, nameof(templateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTemplate.TryParseName(templateName, out resourceName))
            {
                result = FromProjectLocationTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(templateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string templateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TemplateId = templateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        public TemplateName(string projectId, string locationId, string templateId) : this(ResourceNameType.ProjectLocationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), templateId: gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)))
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
        /// The <c>Template</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TemplateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTemplate: return s_projectLocationTemplate.Expand(ProjectId, LocationId, TemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TemplateName);

        /// <inheritdoc/>
        public bool Equals(TemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TemplateName a, TemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TemplateName a, TemplateName b) => !(a == b);
    }

    public partial class ModelArmorConfig
    {
        /// <summary>
        /// <see cref="TemplateName"/>-typed view over the <see cref="PromptTemplateName"/> resource name property.
        /// </summary>
        public TemplateName PromptTemplateNameAsTemplateName
        {
            get => string.IsNullOrEmpty(PromptTemplateName) ? null : TemplateName.Parse(PromptTemplateName, allowUnparsed: true);
            set => PromptTemplateName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TemplateName"/>-typed view over the <see cref="ResponseTemplateName"/> resource name property.
        /// </summary>
        public TemplateName ResponseTemplateNameAsTemplateName
        {
            get => string.IsNullOrEmpty(ResponseTemplateName) ? null : TemplateName.Parse(ResponseTemplateName, allowUnparsed: true);
            set => ResponseTemplateName = value?.ToString() ?? "";
        }
    }
}
