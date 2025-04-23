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
using gcfv = Google.Cloud.FinancialServices.V1;
using sys = System;

namespace Google.Cloud.FinancialServices.V1
{
    /// <summary>Resource name for the <c>PredictionResult</c> resource.</summary>
    public sealed partial class PredictionResultName : gax::IResourceName, sys::IEquatable<PredictionResultName>
    {
        /// <summary>The possible contents of <see cref="PredictionResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
            /// .
            /// </summary>
            ProjectNumLocationInstancePredictionResult = 1,
        }

        private static gax::PathTemplate s_projectNumLocationInstancePredictionResult = new gax::PathTemplate("projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}");

        /// <summary>Creates a <see cref="PredictionResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PredictionResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PredictionResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PredictionResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PredictionResultName"/> with the pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// .
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionResultId">The <c>PredictionResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PredictionResultName"/> constructed from the provided ids.</returns>
        public static PredictionResultName FromProjectNumLocationInstancePredictionResult(string projectNumId, string locationId, string instanceId, string predictionResultId) =>
            new PredictionResultName(ResourceNameType.ProjectNumLocationInstancePredictionResult, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), predictionResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PredictionResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// .
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionResultId">The <c>PredictionResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PredictionResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// .
        /// </returns>
        public static string Format(string projectNumId, string locationId, string instanceId, string predictionResultId) =>
            FormatProjectNumLocationInstancePredictionResult(projectNumId, locationId, instanceId, predictionResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PredictionResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// .
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionResultId">The <c>PredictionResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PredictionResultName"/> with pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// .
        /// </returns>
        public static string FormatProjectNumLocationInstancePredictionResult(string projectNumId, string locationId, string instanceId, string predictionResultId) =>
            s_projectNumLocationInstancePredictionResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PredictionResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="predictionResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PredictionResultName"/> if successful.</returns>
        public static PredictionResultName Parse(string predictionResultName) => Parse(predictionResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PredictionResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="predictionResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PredictionResultName"/> if successful.</returns>
        public static PredictionResultName Parse(string predictionResultName, bool allowUnparsed) =>
            TryParse(predictionResultName, allowUnparsed, out PredictionResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PredictionResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="predictionResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PredictionResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string predictionResultName, out PredictionResultName result) =>
            TryParse(predictionResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PredictionResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="predictionResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PredictionResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string predictionResultName, bool allowUnparsed, out PredictionResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(predictionResultName, nameof(predictionResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNumLocationInstancePredictionResult.TryParseName(predictionResultName, out resourceName))
            {
                result = FromProjectNumLocationInstancePredictionResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(predictionResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PredictionResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string predictionResultId = null, string projectNumId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            PredictionResultId = predictionResultId;
            ProjectNumId = projectNumId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PredictionResultName"/> class from the component parts of pattern
        /// <c>projects/{project_num}/locations/{location}/instances/{instance}/predictionResults/{prediction_result}</c>
        /// </summary>
        /// <param name="projectNumId">The <c>ProjectNum</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionResultId">The <c>PredictionResult</c> ID. Must not be <c>null</c> or empty.</param>
        public PredictionResultName(string projectNumId, string locationId, string instanceId, string predictionResultId) : this(ResourceNameType.ProjectNumLocationInstancePredictionResult, projectNumId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectNumId, nameof(projectNumId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), predictionResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PredictionResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PredictionResultId { get; }

        /// <summary>
        /// The <c>ProjectNum</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectNumId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectNumLocationInstancePredictionResult: return s_projectNumLocationInstancePredictionResult.Expand(ProjectNumId, LocationId, InstanceId, PredictionResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PredictionResultName);

        /// <inheritdoc/>
        public bool Equals(PredictionResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PredictionResultName a, PredictionResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PredictionResultName a, PredictionResultName b) => !(a == b);
    }

    public partial class PredictionResult
    {
        /// <summary>
        /// <see cref="gcfv::PredictionResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::PredictionResultName PredictionResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::PredictionResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Dataset"/> resource name property.
        /// </summary>
        public DatasetName DatasetAsDatasetName
        {
            get => string.IsNullOrEmpty(Dataset) ? null : DatasetName.Parse(Dataset, allowUnparsed: true);
            set => Dataset = value?.ToString() ?? "";
        }

        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class ListPredictionResultsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPredictionResultRequest
    {
        /// <summary>
        /// <see cref="gcfv::PredictionResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::PredictionResultName PredictionResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::PredictionResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePredictionResultRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePredictionResultRequest
    {
        /// <summary>
        /// <see cref="gcfv::PredictionResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfv::PredictionResultName PredictionResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfv::PredictionResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportPredictionResultMetadataRequest
    {
        /// <summary>
        /// <see cref="PredictionResultName"/>-typed view over the <see cref="PredictionResult"/> resource name
        /// property.
        /// </summary>
        public PredictionResultName PredictionResultAsPredictionResultName
        {
            get => string.IsNullOrEmpty(PredictionResult) ? null : PredictionResultName.Parse(PredictionResult, allowUnparsed: true);
            set => PredictionResult = value?.ToString() ?? "";
        }
    }
}
