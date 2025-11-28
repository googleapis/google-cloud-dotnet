# Version history

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
