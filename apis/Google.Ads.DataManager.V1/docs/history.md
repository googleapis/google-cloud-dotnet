# Version history

## Version 1.0.0-beta04, released 2026-02-23

### New features

- Add `UserListService` for creating and managing user lists
- Add `UserListDirectLicenseService` for creating and managing direct user list licenses
- Add `UserListGlobalLicenseService` for creating and managing global user list licenses
- Add `MarketingDataInsightsService` for retrieving marketing data insights for a given user list
- Add `PartnerLinkService` for creating and managing links between advertiser and data partner accounts
- Add `UserList` resource
- Add `UserListDirectLicense` resource
- Add `UserListGlobalLicense` resource
- Add `UserListGlobalLicenseCustomerInfo` resource
- Add `PartnerLink` resource
- Add `UserIdData` to `AudienceMember` to support User ID in audience member ingestion
- Add `PpidData` to `AudienceMember` to support Publisher Provided ID (PPID) in audience member ingestion
- Add `IngestUserIdDataStatus` to `IngestAudienceMembersStatus` to report the status of user ID data ingestion
- Add `IngestPpidDataStatus` to `IngestAudienceMembersStatus` to report the status of PPID data ingestion
- Add `RemoveUserIdDataStatus` to `RemoveAudienceMembersStatus` to report the status of user ID data removal
- Add `RemovePpidDataStatus` to `RemoveAudienceMembersStatus` to report the status of PPID data removal
- Add `GOOGLE_AD_MANAGER_AUDIENCE_LINK` to the `AccountType` enum
- Add `AgeRange` and `Gender` enums to support demographic breakdown in marketing insights
- Add new `ErrorReason` values for licensing, user list operations, and permission checks

### Bug fixes

- Changed `conversion_value` field to be optional in message `Event`

### Documentation improvements

- Add comments to resources and methods to clarify which are available only to data partners
- A comment for enum `ErrorReason` is changed to clarify that it is subject to future additions
- A comment for field `pair_data` in message `AudienceMember` is changed to clarify it is only available to data partners
- A comment for message `PairData` is changed to clarify it is only available to data partners

## Version 1.0.0-beta03, released 2026-02-02

### Bug fixes

- Update `go_package` packaging option from `google.golang.org/genproto/googleapis/ads/datamanager/v1;datamanager` to `cloud.google.com/go/datamanager/apiv1/datamanagerpb;datamanagerpb`

### Documentation improvements

- Describe additional URI format for kek_uri in GcpEncryptionInfo and AwsKmsEncryptionInfo

## Version 1.0.0-beta02, released 2025-11-06

### New features

- Add `AwsWrappedKeyInfo` to `EncryptionInfo` for supporting data encryption using AWS KMS keys
- Add `additional_user_properties` to `UserProperties` for sending additional key-value pairs of user properties
- Add `item_id` to `Item` for uniquely identifying an item
- Add `additional_item_parameters` to `Item` for sending additional key-value pairs of item parameters
- Add `GOOGLE_ANALYTICS_PROPERTY` to `AccountType` enum for supporting Google Analytics as a destination
- Add `PROCESSING_ERROR_REASON_AWS_AUTH_FAILED` to `ProcessingErrorReason` enum
- Add `PROCESSING_WARNING_REASON_AWS_AUTH_FAILED` to `ProcessingWarningReason` enum
- Add new error codes `UNSUPPORTED_OPERATING_ACCOUNT_FOR_DATA_PARTNER`, `UNSUPPORTED_LINKED_ACCOUNT_FOR_DATA_PARTNER`, `INVALID_PROPERTY_TYPE`, `INVALID_STREAM_TYPE`, `LINKED_ACCOUNT_ONLY_ALLOWED_WITH_DATA_PARTNER_LOGIN_ACCOUNT`, `OPERATING_ACCOUNT_LOGIN_ACCOUNT_MISMATCH`, `EVENT_TIME_INVALID`, `RESERVED_NAME_USED`, `INVALID_EVENT_NAME`, `NOT_ALLOWLISTED`, `MULTIPLE_DESTINATIONS_FOR_GOOGLE_ANALYTICS_EVENT`, `FIELD_VALUE_TOO_LONG`, `TOO_MANY_ELEMENTS` to `ErrorReason` enum
- Add `event_name` to `Event` for specifying the name of the Google Analytics event
- Add `client_id` to `Event` for uniquely identifying a user instance of a web client for a Google Analytics web stream
- Add `user_id` to `Event` for uniquely identifying a user as defined by the advertiser for Google Analytics events
- Add `additional_event_parameters` to `Event` for sending additional key-value pairs of event parameters for Google Analytics events

## Version 1.0.0-beta01, released 2025-10-24

### New features

- Initial generation for Google.Ads.DataManager.V1

