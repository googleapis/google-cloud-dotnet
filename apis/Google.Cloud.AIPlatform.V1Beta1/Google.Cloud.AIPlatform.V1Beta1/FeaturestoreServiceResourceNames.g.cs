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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateFeaturestoreRequest
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

    public partial class GetFeaturestoreRequest
    {
        /// <summary>
        /// <see cref="gcav::FeaturestoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeaturestoreName FeaturestoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeaturestoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeaturestoresRequest
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

    public partial class DeleteFeaturestoreRequest
    {
        /// <summary>
        /// <see cref="gcav::FeaturestoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeaturestoreName FeaturestoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeaturestoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }

    public partial class BatchReadFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="FeaturestoreName"/>-typed view over the <see cref="Featurestore"/> resource name property.
        /// </summary>
        public FeaturestoreName FeaturestoreAsFeaturestoreName
        {
            get => string.IsNullOrEmpty(Featurestore) ? null : FeaturestoreName.Parse(Featurestore, allowUnparsed: true);
            set => Featurestore = value?.ToString() ?? "";
        }
    }

    public partial class ExportFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntityTypeRequest
    {
        /// <summary>
        /// <see cref="FeaturestoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeaturestoreName ParentAsFeaturestoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeaturestoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcav::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntityTypesRequest
    {
        /// <summary>
        /// <see cref="FeaturestoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeaturestoreName ParentAsFeaturestoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeaturestoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcav::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeatureRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FeatureGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureGroupName ParentAsFeatureGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (EntityTypeName.TryParse(Parent, out EntityTypeName entityType))
                {
                    return entityType;
                }
                if (FeatureGroupName.TryParse(Parent, out FeatureGroupName featureGroup))
                {
                    return featureGroup;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateFeaturesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeaturesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FeatureGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureGroupName ParentAsFeatureGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (EntityTypeName.TryParse(Parent, out EntityTypeName entityType))
                {
                    return entityType;
                }
                if (FeatureGroupName.TryParse(Parent, out FeatureGroupName featureGroup))
                {
                    return featureGroup;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SearchFeaturesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeatureRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeatureValuesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="EntityType"/> resource name property.
        /// </summary>
        public EntityTypeName EntityTypeAsEntityTypeName
        {
            get => string.IsNullOrEmpty(EntityType) ? null : EntityTypeName.Parse(EntityType, allowUnparsed: true);
            set => EntityType = value?.ToString() ?? "";
        }
    }
}
