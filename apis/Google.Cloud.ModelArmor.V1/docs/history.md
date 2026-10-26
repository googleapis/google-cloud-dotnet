# Version history

## Version 1.1.0, released 2026-10-21

### New features

- Expose data_residency_compliant field for Model Armor v1 templates
- Introduce FilterVersionSelector and FilterVersionConfig to specify filter versions
- Add McpServerFloorSetting for Google MCP Server integrations
- Add file_label to ByteDataItem for file identification

### Documentation improvements

- Update comment for field filter_results in SanitizationResult
- Clarify source_language usage in MultiLanguageDetectionMetadata
- Expand description for ListLocations method

## Version 1.0.0, released 2026-08-10

### New features

- Release stable versions of lagging releases

## Version 1.0.0-beta07, released 2026-07-06

### New features

- Add image sanitization support

### Documentation improvements

- A comment for enum value `DISABLED` in enum `PiAndJailbreakFilterEnforcement` is changed
- A comment for field `rai_filter_type_results` in message `.google.cloud.modelarmor.v1.RaiFilterResult` is changed
- A comment for field `byte_range` in message `.google.cloud.modelarmor.v1.SdpFinding` is changed
- A comment for field `codepoint_range` in message `.google.cloud.modelarmor.v1.SdpFinding` is changed

## Version 1.0.0-beta06, released 2026-06-15

### New features

- Add streaming methods StreamSanitizeUserPrompt and StreamSanitizeModelResponse
- Add StreamingMode enum and field to sanitize requests

## Version 1.0.0-beta05, released 2025-11-05

### New features

- Update dependencies

## Version 1.0.0-beta04, released 2025-08-04

### New features

- MultiLanguage Detection in Model Armor Floor Setting

## Version 1.0.0-beta03, released 2025-07-28

### New features

- MultiLanguage Detection in Model Armor Floor Setting
- Add support for EnforcementType

### Documentation improvements

- Fix comment formatting

## Version 1.0.0-beta02, released 2025-07-07

### New features

- Add client libraries for v1beta API
- Support added for `TXT` and `CSV` files
- Add MultiLingual Support for Sanitize APIs

## Version 1.0.0-beta01, released 2025-05-07

### New features

- Initial generation for Google.Cloud.ModelArmor.V1

