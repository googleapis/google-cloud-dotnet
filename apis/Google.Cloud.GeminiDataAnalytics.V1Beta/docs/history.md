# Version history

## Version 1.0.0-beta06, released 2025-12-29

### New features

- Add LookerGoldenQuery to Context
- Add LookerGoldenQuery to Context

### Documentation improvements

- Specify the data sources supported only by the QueryData API

## Version 1.0.0-beta05, released 2025-12-12

### New features

- Add a QueryData API for NL2SQL conversion
- A new message `AgentContextReference` is added
- A new method `QueryData` is added to service `DataChatService`
- A new message `QueryDataRequest` is added
- A new message `GenerationOptions` is added
- A new message `QueryDataContext` is added
- A new message `QueryDataResponse` is added
- A new message `ExecutedQueryResult` is added
- A new field `alloydb` is added to message `.google.cloud.geminidataanalytics.v1beta.DatasourceReferences`
- A new field `spanner_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.DatasourceReferences`
- A new field `cloud_sql_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.DatasourceReferences`
- A new message `AlloyDbReference` is added
- A new message `AlloyDbDatabaseReference` is added
- A new message `SpannerReference` is added
- A new message `SpannerDatabaseReference` is added
- A new message `CloudSqlReference` is added
- A new message `CloudSqlDatabaseReference` is added
- A new field `alloy_db_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.Datasource`
- A new field `spanner_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.Datasource`
- A new field `cloud_sql_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.Datasource`

## Version 1.0.0-beta04, released 2025-11-10

### New features

- Adding a new SchemaRelationship message to define relationships between table schema
- Adding a new TextType PROGRESS to provide informational messages about an agent's progress for supporting more granular Agent RAG tools
- Adding struct_schema to Datasource to support flexible schemas, particularly for Looker datasources
- Adding client_managed_resource_context to allow clients to manage their own conversation and agent resources
- Adding a DeleteConversation RPC to allow for the deletion of conversations
- Adding a GlossaryTerm message to allow users to provide definitions for domain-specific terms
- Adding an ExampleQueries message to surface derived and authored example queries
- Adding DatasourceOptions to provide configuration options for datasources
- Adding support for LookerQuery within the DataQuery message for retrieving data from Looker explores

## Version 1.0.0-beta03, released 2025-11-05

### New features

- Update dependencies

## Version 1.0.0-beta02, released 2025-08-28

### New features

- A new field `example_queries` is added to message `.google.cloud.geminidataanalytics.v1alpha.Context`
- A new message `ExampleQuery` is added
- A new enum `DataFilterType` is added
- A new field `schema` is added to message `.google.cloud.geminidataanalytics.v1alpha.BigQueryTableReference`
- A new field `description` is added to message `.google.cloud.geminidataanalytics.v1alpha.Schema`
- A new field `synonyms` is added to message `.google.cloud.geminidataanalytics.v1alpha.Schema`
- A new field `tags` is added to message `.google.cloud.geminidataanalytics.v1alpha.Schema`
- A new field `filters` is added to message `.google.cloud.geminidataanalytics.v1alpha.Schema`
- A new field `synonyms` is added to message `.google.cloud.geminidataanalytics.v1alpha.Field`
- A new field `tags` is added to message `.google.cloud.geminidataanalytics.v1alpha.Field`
- A new field `value_format` is added to message `.google.cloud.geminidataanalytics.v1alpha.Field`
- A new message `DataFilter` is added

### Bug fixes

- An existing service `ContextRetrievalService` is removed

### Documentation improvements

- Many comment updates

## Version 1.0.0-beta01, released 2025-08-13

### New features

- Initial generation for Google.Cloud.GeminiDataAnalytics.V1Beta

### Bug fixes

- Correct resource reference type for `parent` field in `data_chat_service.proto`

