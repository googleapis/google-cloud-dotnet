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

namespace Google.Ads.AdManager.V1
{
    public partial class GeoTargeting
    {
        /// <summary>
        /// <see cref="GeoTargetName"/>-typed view over the <see cref="TargetedGeos"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<GeoTargetName> TargetedGeosAsGeoTargetNames
        {
            get => new gax::ResourceNameList<GeoTargetName>(TargetedGeos, s => string.IsNullOrEmpty(s) ? null : GeoTargetName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="GeoTargetName"/>-typed view over the <see cref="ExcludedGeos"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<GeoTargetName> ExcludedGeosAsGeoTargetNames
        {
            get => new gax::ResourceNameList<GeoTargetName>(ExcludedGeos, s => string.IsNullOrEmpty(s) ? null : GeoTargetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BandwidthTargeting
    {
        /// <summary>
        /// <see cref="BandwidthGroupName"/>-typed view over the <see cref="TargetedBandwidthGroups"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<BandwidthGroupName> TargetedBandwidthGroupsAsBandwidthGroupNames
        {
            get => new gax::ResourceNameList<BandwidthGroupName>(TargetedBandwidthGroups, s => string.IsNullOrEmpty(s) ? null : BandwidthGroupName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="BandwidthGroupName"/>-typed view over the <see cref="ExcludedBandwidthGroups"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<BandwidthGroupName> ExcludedBandwidthGroupsAsBandwidthGroupNames
        {
            get => new gax::ResourceNameList<BandwidthGroupName>(ExcludedBandwidthGroups, s => string.IsNullOrEmpty(s) ? null : BandwidthGroupName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DeviceCategoryTargeting
    {
        /// <summary>
        /// <see cref="DeviceCategoryName"/>-typed view over the <see cref="TargetedCategories"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<DeviceCategoryName> TargetedCategoriesAsDeviceCategoryNames
        {
            get => new gax::ResourceNameList<DeviceCategoryName>(TargetedCategories, s => string.IsNullOrEmpty(s) ? null : DeviceCategoryName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DeviceCategoryName"/>-typed view over the <see cref="ExcludedCategories"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<DeviceCategoryName> ExcludedCategoriesAsDeviceCategoryNames
        {
            get => new gax::ResourceNameList<DeviceCategoryName>(ExcludedCategories, s => string.IsNullOrEmpty(s) ? null : DeviceCategoryName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class OperatingSystemTargeting
    {
        /// <summary>
        /// <see cref="OperatingSystemName"/>-typed view over the <see cref="TargetedOperatingSystems"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<OperatingSystemName> TargetedOperatingSystemsAsOperatingSystemNames
        {
            get => new gax::ResourceNameList<OperatingSystemName>(TargetedOperatingSystems, s => string.IsNullOrEmpty(s) ? null : OperatingSystemName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="OperatingSystemName"/>-typed view over the <see cref="ExcludedOperatingSystems"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<OperatingSystemName> ExcludedOperatingSystemsAsOperatingSystemNames
        {
            get => new gax::ResourceNameList<OperatingSystemName>(ExcludedOperatingSystems, s => string.IsNullOrEmpty(s) ? null : OperatingSystemName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="OperatingSystemVersionName"/>-typed view over the <see cref="TargetedOperatingSystemVersions"/>
        /// resource name property.
        /// </summary>
        public gax::ResourceNameList<OperatingSystemVersionName> TargetedOperatingSystemVersionsAsOperatingSystemVersionNames
        {
            get => new gax::ResourceNameList<OperatingSystemVersionName>(TargetedOperatingSystemVersions, s => string.IsNullOrEmpty(s) ? null : OperatingSystemVersionName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="OperatingSystemVersionName"/>-typed view over the <see cref="ExcludedOperatingSystemVersions"/>
        /// resource name property.
        /// </summary>
        public gax::ResourceNameList<OperatingSystemVersionName> ExcludedOperatingSystemVersionsAsOperatingSystemVersionNames
        {
            get => new gax::ResourceNameList<OperatingSystemVersionName>(ExcludedOperatingSystemVersions, s => string.IsNullOrEmpty(s) ? null : OperatingSystemVersionName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class InventoryTargeting
    {
        /// <summary>
        /// <see cref="PlacementName"/>-typed view over the <see cref="TargetedPlacements"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PlacementName> TargetedPlacementsAsPlacementNames
        {
            get => new gax::ResourceNameList<PlacementName>(TargetedPlacements, s => string.IsNullOrEmpty(s) ? null : PlacementName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class AdUnitTargeting
    {
        /// <summary><see cref="AdUnitName"/>-typed view over the <see cref="AdUnit"/> resource name property.</summary>
        public AdUnitName AdUnitAsAdUnitName
        {
            get => string.IsNullOrEmpty(AdUnit) ? null : AdUnitName.Parse(AdUnit, allowUnparsed: true);
            set => AdUnit = value?.ToString() ?? "";
        }
    }

    public partial class CustomTargetingLiteral
    {
        /// <summary>
        /// <see cref="CustomTargetingKeyName"/>-typed view over the <see cref="CustomTargetingKey"/> resource name
        /// property.
        /// </summary>
        public CustomTargetingKeyName CustomTargetingKeyAsCustomTargetingKeyName
        {
            get => string.IsNullOrEmpty(CustomTargetingKey) ? null : CustomTargetingKeyName.Parse(CustomTargetingKey, allowUnparsed: true);
            set => CustomTargetingKey = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomTargetingValueName"/>-typed view over the <see cref="CustomTargetingValues"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<CustomTargetingValueName> CustomTargetingValuesAsCustomTargetingValueNames
        {
            get => new gax::ResourceNameList<CustomTargetingValueName>(CustomTargetingValues, s => string.IsNullOrEmpty(s) ? null : CustomTargetingValueName.Parse(s, allowUnparsed: true));
        }
    }
}
