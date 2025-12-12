# Version history

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
