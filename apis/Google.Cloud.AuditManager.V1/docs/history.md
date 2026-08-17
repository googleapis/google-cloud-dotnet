# Version history

## Version 1.2.0, released 2026-08-17

### New features

- Add organizations level support for GenerateAuditScopeReport, GenerateAuditReport and GetAuditReport
- Add `validate_only` field to GenerateAuditReportRequest
- Deprecated the old `compliance_standard` field in favour of `compliance_framework` for GenerateAuditScopeReport and GenerateAuditReport
- Add `https://www.googleapis.com/auth/cloud-auditmanager` OAuth scope

### Documentation improvements

- Update documentation for validate_only
- Clarify documentation for several RPCs, resource messages, and enumerations

## Version 1.1.0, released 2026-08-10

### New features

- Release stable versions of lagging releases

## Version 1.0.0, released 2026-08-10

### New features

- Release stable version

## Version 1.0.0-beta03, released 2026-03-02

### Bug fixes

- Update existing packaging option `cloud.google.com/go/auditmanager/apiv1/auditmanagerpb;auditmanagerpb` for `go_package`

## Version 1.0.0-beta02, released 2026-02-16

### Bug fixes

- A new packaging option `cloud.google.com/go/auditmanager/apiv1main/auditmanagerpb;auditmanagerpb` for `go_package` is added
- An existing packaging option `google.golang.org/genproto/googleapis/cloud/auditmanager/v1;auditmanager` for `go_package` is removed

## Version 1.0.0-beta01, released 2026-01-29

### New features

- Initial generation for Google.Cloud.AuditManager.V1

