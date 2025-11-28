# Version history

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

