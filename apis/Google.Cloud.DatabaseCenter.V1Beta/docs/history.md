# Version history

## Version 1.0.0-beta07, released 2026-04-13

### New features

- Add support for BigQuery datasets and reservations
- Introduce resource affiliation and lineage tracking
- Enhance maintenance information with state, upcoming maintenance, and failure reasons

## Version 1.0.0-beta06, released 2026-03-23

### New features

- A new value `SUB_RESOURCE_TYPE_READ_POOL` is added to enum `SubResourceType`
- A new value `SUB_RESOURCE_TYPE_RESERVATION` is added to enum `SubResourceType`
- A new value `SUB_RESOURCE_TYPE_DATASET` is added to enum `SubResourceType`
- A new value `SIGNAL_TYPE_VERSION_NEARING_END_OF_LIFE` is added to enum `SignalType

### Documentation improvements

- Modified comment for Edition Enum
- Replace "GCP" with "Google Cloud" in API comments
- Remove single quotes from DatabaseCenter summary.

## Version 1.0.0-beta05, released 2026-02-16

### New features

- Adding Method QueryIssues of Database Center API v1beta

### Documentation improvements

- A comment for field `maintenance_version` in message `.google.cloud.databasecenter.v1beta.MaintenanceInfo` is changed
- A comment for field `filter` in message `.google.cloud.databasecenter.v1beta.QueryDatabaseResourceGroupsRequest` is changed
- A comment for field `order_by` in message `.google.cloud.databasecenter.v1beta.QueryDatabaseResourceGroupsRequest` is changed
- A comment for field `filter` in message `.google.cloud.databasecenter.v1beta.AggregateIssueStatsRequest` is changed
- A comment for field `filter` in message `.google.cloud.databasecenter.v1beta.AggregateFleetRequest` is changed
- A comment for field `order_by` in message `.google.cloud.databasecenter.v1beta.AggregateFleetRequest` is changed
- A comment for message `AggregateFleetResponse` is changed

## Version 1.0.0-beta04, released 2026-01-19

### New features

- Adding Method AggregateIssueStats of Database Center API v1beta

## Version 1.0.0-beta03, released 2026-01-08

### New features

- Adding Method AggregateFleet of Database Center API v1beta

## Version 1.0.0-beta02, released 2026-01-05

### New features

- Adding Method QueryDatabaseResourceGroups of Database Center API v1beta

## Version 1.0.0-beta01, released 2025-11-11

### New features

- Initial generation for Google.Cloud.DatabaseCenter.V1Beta

