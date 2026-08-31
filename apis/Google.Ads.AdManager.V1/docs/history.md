# Version history

## Version 1.0.0-beta10, released 2026-08-31

### New features

- Added methods for activation, deactivation, approval, rejection, and population of audience segments
- Added `HIGH_ENGAGEMENT_ADS_ALLOWED` report dimension
- Added `WEB_INTERSTITIAL_TRIGGER_TYPE` report dimension
- Added `WEB_INTERSTITIAL_TRIGGER_TYPE_NAME` report dimension
- Added `UpdateNetwork`, `ProvisionTestNetwork`, and `GetDefaultThirdPartyDataDeclaration` to NetworkService
- Added additional AudienceSegment fields

### Documentation improvements

- Updated documentation for AudienceSegmentService endpoints
- Additional columns are now filterable in `ListAudienceSegmentsRequest`

## Version 1.0.0-beta09, released 2026-08-17

### New features

- Added `PartnerService`
- Added create and update methods for `CompanyService`
- Added `CreativeWrapperService`
- Added `ChildPublisherService`
- Added `dvrWindowDuration` field to `LiveStream` resource
- Added `refreshRateType` to AdUnit
- Added ViewabilityProviderService
- Added REQUESTED_CREATIVE_ORIENTATION dimension to the Report API
- Added `IMPRESSIONS_WITH_COMPANION` report dimension
- Added `CTR_WITH_COMPANION` report dimension
- A new value `LANDING_PAGE_DOMAIN` is added to enum `Dimension`
- Added `daiAuthenticationKeys`, `segmentUrlAuthenticationKeys`, and `daiEncofingProfiles` fields to `LiveStream`
- A new message `ReportVisibilityEnum` is added
- Added pod report dimensions and metrics
- Added `DaiEncodingProfileService`
- Added `DaiAuthenticationKeyService`
- Added `slate` field to `LiveStream`

### Bug fixes

- Fixed batchApproveSuggestedAdUnits HTTP binding
- The type of an existing field `visibility` is changed from `Report.Visibility` to `ReportVisibilityEnum.ReportVisibility` in message `Report`.

### Documentation improvements

- Updated many method descriptions to use a consistent style
- A comment for enum value `ADVERTISER_DOMAIN_NAME` in enum `Dimension` is changed to prefer the new `LANDING_PAGE_DOMAIN` name.
- Minor documentation adjustments

## Version 1.0.0-beta08, released 2026-07-28

### New features

- Added additional LineItem fields
- Added `BatchActivateContentBundles` and `BatchDeactivateContentBundles` methods to `ContentBundleService`
- Added CreativeSetService
- Added `SlateService`
- Added the Creative entity
- Added OrderService write methods and additional stats fields.
- Added TargetingPresetService update methods

### Bug fixes

- Moved Schedule messages from report_messages.proto to report_delivery.proto

### Documentation improvements

- Updated method descriptions to use a consistent style

## Version 1.0.0-beta07, released 2026-07-20

### New features

- Added AdSpotService
- Added CdnConfigService
- Added LiveStreamService
- Added TargetingPresetService
- Added SuggestedAdUnitService
- Added ThirdPartyCompanyService
- Added `status` and `updateTime` fields to ContentBundle
- Added write methods for CustomTargetingValue
- Added `DECLARED_ADVERTISER_DOMAIN` report Dimension

### Documentation improvements

- Normalized documentation on standard methods

## Version 1.0.0-beta06, released 2026-05-11

### New features

- Added new API dimension: CREATIVE_SSL_COMPLIANCE_OVERRIDE
- Added new PUBLIC dimension: CREATIVE_SSL_COMPLIANCE_OVERRIDE_NAME
- Added new API dimension: CREATIVE_SSL_SCAN_RESULT
- Added new PUBLIC dimension: CREATIVE_SSL_SCAN_RESULT_NAME
- Added new PUBLIC metric: AD_SERVER_ACTIVE_VIEW_REVENUE
- Added new PUBLIC dimension: LINE_ITEM_AVERAGE_NUMBER_OF_VIEWERS
- Add readonly OAuth scope
- Add ProposalLineItem service and messages to the API.
- Added new PUBLIC dimension: TARGETS_CUSTOMER_MATCHING_LIST
- Expose both `get` and `list` methods for RichMediaAdsCompanies to external clients.
- A new message `ApplicationStoreEnum` is added
- A new message `ApplicationApprovalStatusEnum` is added
- A new message `ApplicationPlatformEnum` is added
- A new message `WebviewClaimingStatusEnum` is added
- A new field `app_store_id` is added to message `.google.ads.admanager.v1.Application`
- A new field `app_stores` is added to message `.google.ads.admanager.v1.Application`
- A new field `archived` is added to message `.google.ads.admanager.v1.Application`
- A new field `app_store_display_name` is added to message `.google.ads.admanager.v1.Application`
- A new field `application_code` is added to message `.google.ads.admanager.v1.Application`
- A new field `developer` is added to message `.google.ads.admanager.v1.Application`
- A new field `platform` is added to message `.google.ads.admanager.v1.Application`
- A new field `free` is added to message `.google.ads.admanager.v1.Application`
- A new field `download_url` is added to message `.google.ads.admanager.v1.Application`
- A new field `approval_status` is added to message `.google.ads.admanager.v1.Application`
- A new field `webview_claiming_status` is added to message `.google.ads.admanager.v1.Application`
- A new method `CreateApplication` is added to service `ApplicationService`
- A new method `BatchCreateApplications` is added to service `ApplicationService`
- A new method `UpdateApplication` is added to service `ApplicationService`
- A new method `BatchUpdateApplications` is added to service `ApplicationService`
- A new method `BatchArchiveApplications` is added to service `ApplicationService`
- A new method `BatchUnarchiveApplications` is added to service `ApplicationService`
- A new message `CreateApplicationRequest` is added
- A new message `BatchCreateApplicationsRequest` is added
- A new message `BatchCreateApplicationsResponse` is added
- A new message `UpdateApplicationRequest` is added
- A new message `BatchUpdateApplicationsRequest` is added
- A new message `BatchUpdateApplicationsResponse` is added
- A new message `BatchArchiveApplicationsRequest` is added
- A new message `BatchArchiveApplicationsResponse` is added
- A new message `BatchUnarchiveApplicationsRequest` is added
- A new message `BatchUnarchiveApplicationsResponse` is added
- Added child publisher resource.
- Added McmEarnings service
- This is referenced for delegation_type in mcm_earnings
- New REQUIRED field `display_name` in message `.google.ads.admanager.v1.Label`
- New REQUIRED field `types` in message `.google.ads.admanager.v1.Label`

### Bug fixes

- An existing value `DEMAND_SUBCHANNEL_ALL` is removed from enum `Dimension`
- Changed field behavior for an existing field `display_name` in message `.google.ads.admanager.v1.Application`
- Removed UNIFIED_PRICING_RULE_ID dimension
- Removed UNIFIED_PRICING_RULE_NAME dimension
- Remove unused AdManagerError type

### Documentation improvements

- A comment for enum value `DEMAND_SUBCHANNEL` in enum `Dimension` is changed
- A comment for enum value `DEMAND_SUBCHANNEL_NAME` in enum `Dimension` is changed
- A comment for enum value `PRICING_RULE_ID` in enum `Dimension` is changed
- A comment for enum value `PRICING_RULE_NAME` in enum `Dimension` is changed
- A comment for enum value `UNIFIED_PRICING_RULE_ID` in enum `Dimension` is changed
- A comment for enum value `UNIFIED_PRICING_RULE_NAME` in enum `Dimension` is changed
- Replace all curly quotes with regular quotes
- Replace 'via' in all docs
- Remove usage of and/or slashes
- Expand regex to regular expression
- `UNIFIED_PRICING_RULE_ID` in enum `Dimension` is deprecated
- `UNIFIED_PRICING_RULE_NAME` in enum `Dimension` is deprecated
- Clarify the behavior of the date_time_range filter when combined with a PENDING manual_review_status.
- A comment for field `display_name` in message `.google.ads.admanager.v1.Application` is changed
- A comment for field `filter` in message `.google.ads.admanager.v1.ListApplicationsRequest` is changed

## Version 1.0.0-beta05, released 2025-12-12

### New features

- Added LineItem service
- Added additional Report metrics and dimensions
- Added write methods for AdUnits
- Added write methods for CustomTargetingKeys

### Bug fixes

- Added proto3 optional to Network primitive fields
- Added pagination to ListNetworks
- Renamed `USER_MESSAGES_CCPA_MESSAGES_SHOWN` `Metric` to `USER_MESSAGES_US_STATES_MESSAGES_SHOWN`

### Documentation improvements

- Updated documentation for `ad_review_center_ad_id` filter
- Updated documentation for Report metrics and dimensions
- Made `status` optional for SearchAdReviewCenterAds

## Version 1.0.0-beta04, released 2025-11-03

### New features

- Update dependencies

## Version 1.0.0-beta03, released 2025-10-23

### New features

- Added Application resource
- Added AudienceSegment resource
- Added Browser resource
- Added BrowserLanguage resource
- Added CmsMetadataKey resource
- Added CmsMetadataValue resource
- Added methods for reading and writing Contact resources
- Added DeviceCapability resource
- Added DeviceManufacturer resource
- Added MobileCarrier resource
- Added MobileDevice resource
- Added MobileDeviceSubmodel resource
- Added additional Report dimensions and metrics
- Added Content resource
- Added ContentBundle resource
- Added ContentLabel resource
- Added CreativeTemplate resource
- Added Team resource
- Added required field `displayName` to Team
- Added Site resource
- Added AdReviewCenterAd methods
- Added required fields `displayName` and `company` to Contact

### Bug fixes

- Made AdUnitSize fields proto3 optional
- Made Label fields proto3 optional
- Made Contact fields proto3 optional
- Made Company fields proto3 optional
- Moved multiple Report messages and submessages
- Renamed ReportDefinition.Dimensions PROGRAMMATIC_BUYER_ID and PROGRAMMATIC_BUYER_NAME to DEAL_BUYER_ID and DEAL_BUYER_NAME
- Renamed ReportDefinition.Dimension AD_SERVER_UNFILTERED_IMPRESSIONS to AD_SERVER_UNFILTERED_DOWNLOADED_IMPRESSIONS

### Documentation improvements

- Clarified pagination defaults for List methods

## Version 1.0.0-beta02, released 2025-07-07

### New features

- Added support for AdBreak resource
- Added support for PrivateAuction resource
- Added support for GeoTarget resource
- Added support for BandwidthGroup resource
- Added support for ProgrammaticBuyer
- Added support for OperatingSystem resource
- Added support for OperatingSystemVersion resource
- Added support for DeviceCategory resource
- New required field customTargetingKey added to CustomTargetingValue resource

### Bug fixes

- Added proto3 optional modifier to all primitive type fields
- Moved Company enums to a separate file
- Moved Report messages to a separate file
- Changed canonical resource name format for CustomTargetingValue resource

### Documentation improvements

- Updated documentation for multiple Report enums

## Version 1.0.0-beta01, released 2024-10-03

Initial release.
