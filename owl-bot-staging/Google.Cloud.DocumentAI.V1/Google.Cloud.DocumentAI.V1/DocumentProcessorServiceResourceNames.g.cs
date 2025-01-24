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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.DocumentAI.V1;
using sys = System;

namespace Google.Cloud.DocumentAI.V1
{
    /// <summary>Resource name for the <c>HumanReviewConfig</c> resource.</summary>
    public sealed partial class HumanReviewConfigName : gax::IResourceName, sys::IEquatable<HumanReviewConfigName>
    {
        /// <summary>The possible contents of <see cref="HumanReviewConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
            /// </summary>
            ProjectLocationProcessor = 1,
        }

        private static gax::PathTemplate s_projectLocationProcessor = new gax::PathTemplate("projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig");

        /// <summary>Creates a <see cref="HumanReviewConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HumanReviewConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HumanReviewConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HumanReviewConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HumanReviewConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HumanReviewConfigName"/> constructed from the provided ids.</returns>
        public static HumanReviewConfigName FromProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            new HumanReviewConfigName(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HumanReviewConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HumanReviewConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string processorId) =>
            FormatProjectLocationProcessor(projectId, locationId, processorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HumanReviewConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HumanReviewConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>.
        /// </returns>
        public static string FormatProjectLocationProcessor(string projectId, string locationId, string processorId) =>
            s_projectLocationProcessor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HumanReviewConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="humanReviewConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HumanReviewConfigName"/> if successful.</returns>
        public static HumanReviewConfigName Parse(string humanReviewConfigName) => Parse(humanReviewConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HumanReviewConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="humanReviewConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HumanReviewConfigName"/> if successful.</returns>
        public static HumanReviewConfigName Parse(string humanReviewConfigName, bool allowUnparsed) =>
            TryParse(humanReviewConfigName, allowUnparsed, out HumanReviewConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HumanReviewConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="humanReviewConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HumanReviewConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string humanReviewConfigName, out HumanReviewConfigName result) =>
            TryParse(humanReviewConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HumanReviewConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="humanReviewConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HumanReviewConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string humanReviewConfigName, bool allowUnparsed, out HumanReviewConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(humanReviewConfigName, nameof(humanReviewConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationProcessor.TryParseName(humanReviewConfigName, out resourceName))
            {
                result = FromProjectLocationProcessor(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(humanReviewConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HumanReviewConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string processorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProcessorId = processorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HumanReviewConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/processors/{processor}/humanReviewConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processorId">The <c>Processor</c> ID. Must not be <c>null</c> or empty.</param>
        public HumanReviewConfigName(string projectId, string locationId, string processorId) : this(ResourceNameType.ProjectLocationProcessor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), processorId: gax::GaxPreconditions.CheckNotNullOrEmpty(processorId, nameof(processorId)))
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
        /// The <c>Processor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessorId { get; }

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
                case ResourceNameType.ProjectLocationProcessor: return s_projectLocationProcessor.Expand(ProjectId, LocationId, ProcessorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HumanReviewConfigName);

        /// <inheritdoc/>
        public bool Equals(HumanReviewConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HumanReviewConfigName a, HumanReviewConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HumanReviewConfigName a, HumanReviewConfigName b) => !(a == b);
    }

    public partial class ProcessRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gax::UnparsedResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchProcessRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gax::UnparsedResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchProcessorTypesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessorTypesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessorsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProcessorTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorTypeName ProcessorTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProcessorRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorVersionName ProcessorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProcessorVersionsRequest
    {
        /// <summary>
        /// <see cref="ProcessorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProcessorName ParentAsProcessorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProcessorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorVersionName ProcessorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorVersionName ProcessorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeployProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorVersionName ProcessorVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProcessorRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProcessorRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnableProcessorRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisableProcessorRequest
    {
        /// <summary>
        /// <see cref="gcdv::ProcessorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ProcessorName ProcessorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ProcessorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SetDefaultProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="ProcessorName"/>-typed view over the <see cref="Processor"/> resource name property.
        /// </summary>
        public ProcessorName ProcessorAsProcessorName
        {
            get => string.IsNullOrEmpty(Processor) ? null : ProcessorName.Parse(Processor, allowUnparsed: true);
            set => Processor = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProcessorVersionName"/>-typed view over the <see cref="DefaultProcessorVersion"/> resource name
        /// property.
        /// </summary>
        public ProcessorVersionName DefaultProcessorVersionAsProcessorVersionName
        {
            get => string.IsNullOrEmpty(DefaultProcessorVersion) ? null : ProcessorVersionName.Parse(DefaultProcessorVersion, allowUnparsed: true);
            set => DefaultProcessorVersion = value?.ToString() ?? "";
        }
    }

    public partial class TrainProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="ProcessorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProcessorName ParentAsProcessorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProcessorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReviewDocumentRequest
    {
        /// <summary>
        /// <see cref="HumanReviewConfigName"/>-typed view over the <see cref="HumanReviewConfig"/> resource name
        /// property.
        /// </summary>
        public HumanReviewConfigName HumanReviewConfigAsHumanReviewConfigName
        {
            get => string.IsNullOrEmpty(HumanReviewConfig) ? null : HumanReviewConfigName.Parse(HumanReviewConfig, allowUnparsed: true);
            set => HumanReviewConfig = value?.ToString() ?? "";
        }
    }

    public partial class EvaluateProcessorVersionRequest
    {
        /// <summary>
        /// <see cref="ProcessorVersionName"/>-typed view over the <see cref="ProcessorVersion"/> resource name
        /// property.
        /// </summary>
        public ProcessorVersionName ProcessorVersionAsProcessorVersionName
        {
            get => string.IsNullOrEmpty(ProcessorVersion) ? null : ProcessorVersionName.Parse(ProcessorVersion, allowUnparsed: true);
            set => ProcessorVersion = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationsRequest
    {
        /// <summary>
        /// <see cref="ProcessorVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProcessorVersionName ParentAsProcessorVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProcessorVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
