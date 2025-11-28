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

    public partial class BrowserTargeting
    {
        /// <summary>
        /// <see cref="BrowserName"/>-typed view over the <see cref="TargetedBrowsers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<BrowserName> TargetedBrowsersAsBrowserNames
        {
            get => new gax::ResourceNameList<BrowserName>(TargetedBrowsers, s => string.IsNullOrEmpty(s) ? null : BrowserName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="BrowserName"/>-typed view over the <see cref="ExcludedBrowsers"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<BrowserName> ExcludedBrowsersAsBrowserNames
        {
            get => new gax::ResourceNameList<BrowserName>(ExcludedBrowsers, s => string.IsNullOrEmpty(s) ? null : BrowserName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class BrowserLanguageTargeting
    {
        /// <summary>
        /// <see cref="BrowserLanguageName"/>-typed view over the <see cref="TargetedBrowserLanguages"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<BrowserLanguageName> TargetedBrowserLanguagesAsBrowserLanguageNames
        {
            get => new gax::ResourceNameList<BrowserLanguageName>(TargetedBrowserLanguages, s => string.IsNullOrEmpty(s) ? null : BrowserLanguageName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="BrowserLanguageName"/>-typed view over the <see cref="ExcludedBrowserLanguages"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<BrowserLanguageName> ExcludedBrowserLanguagesAsBrowserLanguageNames
        {
            get => new gax::ResourceNameList<BrowserLanguageName>(ExcludedBrowserLanguages, s => string.IsNullOrEmpty(s) ? null : BrowserLanguageName.Parse(s, allowUnparsed: true));
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

    public partial class DeviceCapabilityTargeting
    {
        /// <summary>
        /// <see cref="DeviceCapabilityName"/>-typed view over the <see cref="TargetedCapabilities"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<DeviceCapabilityName> TargetedCapabilitiesAsDeviceCapabilityNames
        {
            get => new gax::ResourceNameList<DeviceCapabilityName>(TargetedCapabilities, s => string.IsNullOrEmpty(s) ? null : DeviceCapabilityName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DeviceCapabilityName"/>-typed view over the <see cref="ExcludedCapabilities"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<DeviceCapabilityName> ExcludedCapabilitiesAsDeviceCapabilityNames
        {
            get => new gax::ResourceNameList<DeviceCapabilityName>(ExcludedCapabilities, s => string.IsNullOrEmpty(s) ? null : DeviceCapabilityName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DeviceManufacturerTargeting
    {
        /// <summary>
        /// <see cref="DeviceManufacturerName"/>-typed view over the <see cref="TargetedDeviceManufacturers"/> resource
        /// name property.
        /// </summary>
        public gax::ResourceNameList<DeviceManufacturerName> TargetedDeviceManufacturersAsDeviceManufacturerNames
        {
            get => new gax::ResourceNameList<DeviceManufacturerName>(TargetedDeviceManufacturers, s => string.IsNullOrEmpty(s) ? null : DeviceManufacturerName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="DeviceManufacturerName"/>-typed view over the <see cref="ExcludedDeviceManufacturers"/> resource
        /// name property.
        /// </summary>
        public gax::ResourceNameList<DeviceManufacturerName> ExcludedDeviceManufacturersAsDeviceManufacturerNames
        {
            get => new gax::ResourceNameList<DeviceManufacturerName>(ExcludedDeviceManufacturers, s => string.IsNullOrEmpty(s) ? null : DeviceManufacturerName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="MobileDeviceName"/>-typed view over the <see cref="TargetedMobileDevices"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<MobileDeviceName> TargetedMobileDevicesAsMobileDeviceNames
        {
            get => new gax::ResourceNameList<MobileDeviceName>(TargetedMobileDevices, s => string.IsNullOrEmpty(s) ? null : MobileDeviceName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="MobileDeviceName"/>-typed view over the <see cref="ExcludedMobileDevices"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<MobileDeviceName> ExcludedMobileDevicesAsMobileDeviceNames
        {
            get => new gax::ResourceNameList<MobileDeviceName>(ExcludedMobileDevices, s => string.IsNullOrEmpty(s) ? null : MobileDeviceName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="MobileDeviceSubmodelName"/>-typed view over the <see cref="TargetedMobileDeviceSubmodels"/>
        /// resource name property.
        /// </summary>
        public gax::ResourceNameList<MobileDeviceSubmodelName> TargetedMobileDeviceSubmodelsAsMobileDeviceSubmodelNames
        {
            get => new gax::ResourceNameList<MobileDeviceSubmodelName>(TargetedMobileDeviceSubmodels, s => string.IsNullOrEmpty(s) ? null : MobileDeviceSubmodelName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="MobileDeviceSubmodelName"/>-typed view over the <see cref="ExcludedMobileDeviceSubmodels"/>
        /// resource name property.
        /// </summary>
        public gax::ResourceNameList<MobileDeviceSubmodelName> ExcludedMobileDeviceSubmodelsAsMobileDeviceSubmodelNames
        {
            get => new gax::ResourceNameList<MobileDeviceSubmodelName>(ExcludedMobileDeviceSubmodels, s => string.IsNullOrEmpty(s) ? null : MobileDeviceSubmodelName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class MobileCarrierTargeting
    {
        /// <summary>
        /// <see cref="MobileCarrierName"/>-typed view over the <see cref="TargetedMobileCarriers"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<MobileCarrierName> TargetedMobileCarriersAsMobileCarrierNames
        {
            get => new gax::ResourceNameList<MobileCarrierName>(TargetedMobileCarriers, s => string.IsNullOrEmpty(s) ? null : MobileCarrierName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="MobileCarrierName"/>-typed view over the <see cref="ExcludedMobileCarriers"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<MobileCarrierName> ExcludedMobileCarriersAsMobileCarrierNames
        {
            get => new gax::ResourceNameList<MobileCarrierName>(ExcludedMobileCarriers, s => string.IsNullOrEmpty(s) ? null : MobileCarrierName.Parse(s, allowUnparsed: true));
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

    public partial class AudienceSegmentTargeting
    {
        /// <summary>
        /// <see cref="AudienceSegmentName"/>-typed view over the <see cref="AudienceSegments"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AudienceSegmentName> AudienceSegmentsAsAudienceSegmentNames
        {
            get => new gax::ResourceNameList<AudienceSegmentName>(AudienceSegments, s => string.IsNullOrEmpty(s) ? null : AudienceSegmentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CmsMetadataTargeting
    {
        /// <summary>
        /// <see cref="CmsMetadataValueName"/>-typed view over the <see cref="CmsMetadataValues"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<CmsMetadataValueName> CmsMetadataValuesAsCmsMetadataValueNames
        {
            get => new gax::ResourceNameList<CmsMetadataValueName>(CmsMetadataValues, s => string.IsNullOrEmpty(s) ? null : CmsMetadataValueName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ContentTargeting
    {
        /// <summary>
        /// <see cref="ContentName"/>-typed view over the <see cref="TargetedContent"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContentName> TargetedContentAsContentNames
        {
            get => new gax::ResourceNameList<ContentName>(TargetedContent, s => string.IsNullOrEmpty(s) ? null : ContentName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ContentName"/>-typed view over the <see cref="ExcludedContent"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ContentName> ExcludedContentAsContentNames
        {
            get => new gax::ResourceNameList<ContentName>(ExcludedContent, s => string.IsNullOrEmpty(s) ? null : ContentName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ContentBundleName"/>-typed view over the <see cref="TargetedContentBundles"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<ContentBundleName> TargetedContentBundlesAsContentBundleNames
        {
            get => new gax::ResourceNameList<ContentBundleName>(TargetedContentBundles, s => string.IsNullOrEmpty(s) ? null : ContentBundleName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ContentBundleName"/>-typed view over the <see cref="ExcludedContentBundles"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<ContentBundleName> ExcludedContentBundlesAsContentBundleNames
        {
            get => new gax::ResourceNameList<ContentBundleName>(ExcludedContentBundles, s => string.IsNullOrEmpty(s) ? null : ContentBundleName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class FirstPartyMobileApplicationTargeting
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="TargetedApplications"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ApplicationName> TargetedApplicationsAsApplicationNames
        {
            get => new gax::ResourceNameList<ApplicationName>(TargetedApplications, s => string.IsNullOrEmpty(s) ? null : ApplicationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="ExcludedApplications"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ApplicationName> ExcludedApplicationsAsApplicationNames
        {
            get => new gax::ResourceNameList<ApplicationName>(ExcludedApplications, s => string.IsNullOrEmpty(s) ? null : ApplicationName.Parse(s, allowUnparsed: true));
        }
    }
}
