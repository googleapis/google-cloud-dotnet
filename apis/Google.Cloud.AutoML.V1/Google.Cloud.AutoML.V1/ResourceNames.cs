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

namespace Google.Cloud.AutoML.V1
{
    /// <summary>
    /// Resource name for the 'annotation_spec' resource.
    /// </summary>
    public sealed partial class AnnotationSpecName : gax::IResourceName, sys::IEquatable<AnnotationSpecName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}");

        /// <summary>
        /// Parses the given annotation_spec resource name in string form into a new
        /// <see cref="AnnotationSpecName"/> instance.
        /// </summary>
        /// <param name="annotationSpecName">The annotation_spec resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotationSpecName"/> if successful.</returns>
        public static AnnotationSpecName Parse(string annotationSpecName)
        {
            gax::GaxPreconditions.CheckNotNull(annotationSpecName, nameof(annotationSpecName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(annotationSpecName);
            return new AnnotationSpecName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given annotation_spec resource name in string form into a new
        /// <see cref="AnnotationSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="annotationSpecName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="annotationSpecName">The annotation_spec resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AnnotationSpecName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationSpecName, out AnnotationSpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotationSpecName, nameof(annotationSpecName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(annotationSpecName, out resourceName))
            {
                result = new AnnotationSpecName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AnnotationSpecName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The <c>dataset</c> ID. Must not be <c>null</c>.</param>
        /// <param name="annotationSpecId">The <c>annotationSpec</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AnnotationSpecName"/>.</returns>
        public static string Format(string projectId, string locationId, string datasetId, string annotationSpecId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNull(annotationSpecId, nameof(annotationSpecId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AnnotationSpecName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The dataset ID. Must not be <c>null</c>.</param>
        /// <param name="annotationSpecId">The annotationSpec ID. Must not be <c>null</c>.</param>
        public AnnotationSpecName(string projectId, string locationId, string datasetId, string annotationSpecId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            DatasetId = gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId));
            AnnotationSpecId = gax::GaxPreconditions.CheckNotNull(annotationSpecId, nameof(annotationSpecId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The dataset ID. Never <c>null</c>.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The annotationSpec ID. Never <c>null</c>.
        /// </summary>
        public string AnnotationSpecId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, DatasetId, AnnotationSpecId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AnnotationSpecName);

        /// <inheritdoc />
        public bool Equals(AnnotationSpecName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AnnotationSpecName a, AnnotationSpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AnnotationSpecName a, AnnotationSpecName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'dataset' resource.
    /// </summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}");

        /// <summary>
        /// Parses the given dataset resource name in string form into a new
        /// <see cref="DatasetName"/> instance.
        /// </summary>
        /// <param name="datasetName">The dataset resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(datasetName);
            return new DatasetName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given dataset resource name in string form into a new
        /// <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="datasetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="datasetName">The dataset resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DatasetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(datasetName, out resourceName))
            {
                result = new DatasetName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DatasetName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The <c>dataset</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DatasetName"/>.</returns>
        public static string Format(string projectId, string locationId, string datasetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DatasetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The dataset ID. Must not be <c>null</c>.</param>
        public DatasetName(string projectId, string locationId, string datasetId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            DatasetId = gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The dataset ID. Never <c>null</c>.
        /// </summary>
        public string DatasetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, DatasetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc />
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationName"/>.</returns>
        public static string Format(string projectId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'model' resource.
    /// </summary>
    public sealed partial class ModelName : gax::IResourceName, sys::IEquatable<ModelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/models/{model}");

        /// <summary>
        /// Parses the given model resource name in string form into a new
        /// <see cref="ModelName"/> instance.
        /// </summary>
        /// <param name="modelName">The model resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelName"/> if successful.</returns>
        public static ModelName Parse(string modelName)
        {
            gax::GaxPreconditions.CheckNotNull(modelName, nameof(modelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(modelName);
            return new ModelName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given model resource name in string form into a new
        /// <see cref="ModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="modelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="modelName">The model resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ModelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelName, out ModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelName, nameof(modelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(modelName, out resourceName))
            {
                result = new ModelName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ModelName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="modelId">The <c>model</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ModelName"/>.</returns>
        public static string Format(string projectId, string locationId, string modelId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(modelId, nameof(modelId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ModelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="modelId">The model ID. Must not be <c>null</c>.</param>
        public ModelName(string projectId, string locationId, string modelId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ModelId = gax::GaxPreconditions.CheckNotNull(modelId, nameof(modelId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The model ID. Never <c>null</c>.
        /// </summary>
        public string ModelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ModelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ModelName);

        /// <inheritdoc />
        public bool Equals(ModelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ModelName a, ModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ModelName a, ModelName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'model_evaluation' resource.
    /// </summary>
    public sealed partial class ModelEvaluationName : gax::IResourceName, sys::IEquatable<ModelEvaluationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/models/{model}/modelEvaluations/{model_evaluation}");

        /// <summary>
        /// Parses the given model_evaluation resource name in string form into a new
        /// <see cref="ModelEvaluationName"/> instance.
        /// </summary>
        /// <param name="modelEvaluationName">The model_evaluation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelEvaluationName"/> if successful.</returns>
        public static ModelEvaluationName Parse(string modelEvaluationName)
        {
            gax::GaxPreconditions.CheckNotNull(modelEvaluationName, nameof(modelEvaluationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(modelEvaluationName);
            return new ModelEvaluationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given model_evaluation resource name in string form into a new
        /// <see cref="ModelEvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="modelEvaluationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="modelEvaluationName">The model_evaluation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ModelEvaluationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelEvaluationName, out ModelEvaluationName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelEvaluationName, nameof(modelEvaluationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(modelEvaluationName, out resourceName))
            {
                result = new ModelEvaluationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ModelEvaluationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="modelId">The <c>model</c> ID. Must not be <c>null</c>.</param>
        /// <param name="modelEvaluationId">The <c>modelEvaluation</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ModelEvaluationName"/>.</returns>
        public static string Format(string projectId, string locationId, string modelId, string modelEvaluationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(modelId, nameof(modelId)), gax::GaxPreconditions.CheckNotNull(modelEvaluationId, nameof(modelEvaluationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ModelEvaluationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="modelId">The model ID. Must not be <c>null</c>.</param>
        /// <param name="modelEvaluationId">The modelEvaluation ID. Must not be <c>null</c>.</param>
        public ModelEvaluationName(string projectId, string locationId, string modelId, string modelEvaluationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ModelId = gax::GaxPreconditions.CheckNotNull(modelId, nameof(modelId));
            ModelEvaluationId = gax::GaxPreconditions.CheckNotNull(modelEvaluationId, nameof(modelEvaluationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The model ID. Never <c>null</c>.
        /// </summary>
        public string ModelId { get; }

        /// <summary>
        /// The modelEvaluation ID. Never <c>null</c>.
        /// </summary>
        public string ModelEvaluationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ModelId, ModelEvaluationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ModelEvaluationName);

        /// <inheritdoc />
        public bool Equals(ModelEvaluationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ModelEvaluationName a, ModelEvaluationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ModelEvaluationName a, ModelEvaluationName b) => !(a == b);
    }


    public partial class BatchPredictRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDatasetRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.AutoML.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.AutoML.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDatasetRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.DatasetName DatasetName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.DatasetName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeployModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExportDataRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.DatasetName DatasetName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.DatasetName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExportModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetAnnotationSpecRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.AnnotationSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.AnnotationSpecName AnnotationSpecName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.AnnotationSpecName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDatasetRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.DatasetName DatasetName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.DatasetName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetModelEvaluationRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelEvaluationName ModelEvaluationName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelEvaluationName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ImportDataRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.DatasetName DatasetName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.DatasetName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDatasetsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.AutoML.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListModelEvaluationsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ParentAsModelName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListModelsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.AutoML.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class PredictRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UndeployModelRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.AutoML.V1.ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.AutoML.V1.ModelName ModelName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.AutoML.V1.ModelName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}