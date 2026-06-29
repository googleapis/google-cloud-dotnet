# Version history

## Version 1.0.0-beta06, released 2026-06-29

### New features

- Added `force` field to DeleteCollectionRequest to allow deleting a Collection together with its Indexes and DataObjects
- Added `FieldFilter` message and `field_filter` field to ExportDataObjects to restrict which top-level Data Object fields are emitted
- Relaxed `search_text` and `data_field_names` on data object search from REQUIRED to OPTIONAL (required only for the default text search mode)

### Documentation improvements

- Updated documentation for listing locations

## Version 1.0.0-beta05, released 2026-04-13

### New features

- Added CMEK support
- Added UpdateIndex support

### Documentation improvements

- Updated documentation for listing locations
- Updated documentation for Collection.data_schema

## Version 1.0.0-beta04, released 2026-03-16

### New features

- Mark Vector Search v1 API as GA
- Add support for ExportDataObjects

## Version 1.0.0-beta03, released 2026-03-09

### Bug fixes

- Removed field DenseScannParams from SearchHint

### Documentation improvements

- Changed default values for max_replica_count for AutoScaling

## Version 1.0.0-beta02, released 2026-03-02

### Bug fixes

- Removed obsolete field `vertex` from message `.google.cloud.vectorsearch.v1.Ranker`
- Removed obsolete message `VertexRanker`

## Version 1.0.0-beta01, released 2026-02-19

### New features

- Initial generation for Google.Cloud.VectorSearch.V1

