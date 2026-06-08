# Version history

## Version 1.0.0-beta10, released 2026-06-08

### New features

- A new field `user_functions` is added to message `.google.cloud.geminidataanalytics.v1beta.Context`
- A new message `UserFunctions` is added
- A new message `BigQueryRoutine` is added
- A new message `BigQueryRoutineReference` is added
- A new field `parameters` is added to message `.google.cloud.geminidataanalytics.v1beta.ExampleQuery`
- A new message `QueryParameter` is added
- A new message `MatchedQuery` is added
- A new message `QueryParameterValues` is added
- A new message `Citation` is added
- A new message `CitationSource` is added
- A new message `CitationAnchor` is added
- A new resource_definition `cloudkms.googleapis.com/CryptoKey` is added
- A new field `kms_key` is added to message `.google.cloud.geminidataanalytics.v1beta.Conversation`
- A new field `memory_paused` is added to message `.google.cloud.geminidataanalytics.v1beta.Conversation`
- A new field `kms_key` is added to message `.google.cloud.geminidataanalytics.v1beta.DataAgent`
- A new message `Parameter` is added
- A new field `credentials` is added to message `.google.cloud.geminidataanalytics.v1beta.ChatRequest`
- A new field `citation` is added to message `.google.cloud.geminidataanalytics.v1beta.SystemMessage`
- A new value `FOLLOWUP_QUESTIONS` is added to enum `TextType`
- A new field `matched_query` is added to message `.google.cloud.geminidataanalytics.v1beta.DataMessage`
- A new field `property_graph_references` is added to message `.google.cloud.geminidataanalytics.v1beta.BigQueryTableReferences`
- A new field `location_boundary` is added to message `.google.cloud.geminidataanalytics.v1beta.BigQueryTableReference`
- A new message `DatabaseTableReference` is added
- A new field `database_table_references` is added to message `.google.cloud.geminidataanalytics.v1beta.AlloyDbDatabaseReference`
- A new field `database_table_references` is added to message `.google.cloud.geminidataanalytics.v1beta.SpannerDatabaseReference`
- A new field `database_table_references` is added to message `.google.cloud.geminidataanalytics.v1beta.CloudSqlDatabaseReference`
- A new message `BigQueryPropertyGraphReference` is added
- A new field `bigquery_property_graph_reference` is added to message `.google.cloud.geminidataanalytics.v1beta.Datasource`

### Bug fixes

- Changed proto3 optional flag of an existing field `value` in message `.google.cloud.geminidataanalytics.v1beta.LookerQuery`
- The type of an existing field `parameters` is changed from `.google.cloud.geminidataanalytics.v1beta.ParameterizedSecureViewParameters.ParametersEntry` to `.google.cloud.geminidataanalytics.v1beta.ParameterizedSecureViewParameters.Parameter` in message `.google.cloud.geminidataanalytics.v1beta.ParameterizedSecureViewParameters`
- An existing field `region` is removed from message `.google.cloud.geminidataanalytics.v1beta.SpannerDatabaseReference`

### Documentation improvements

- A comment for field `sources` in message `.google.cloud.geminidataanalytics.v1beta.Context` is changed
- A comment for field `confidence_score` in message `.google.cloud.geminidataanalytics.v1beta.Context` is changed
- A comment for field `example_queries` in message `.google.cloud.geminidataanalytics.v1beta.Context` is changed
- A comment for field `looker_golden_queries` in message `.google.cloud.geminidataanalytics.v1beta.Context` is changed
- A comment for field `glossary_terms` in message `.google.cloud.geminidataanalytics.v1beta.Context` is changed
- A comment for field `value` in message `.google.cloud.geminidataanalytics.v1beta.LookerQuery` is changed
- A comment for field `page_size` in message `.google.cloud.geminidataanalytics.v1beta.ListConversationsRequest` is changed
- A comment for method `Chat` in service `DataChatService` is changed
- A comment for field `parameters` in message `.google.cloud.geminidataanalytics.v1beta.ParameterizedSecureViewParameters` is changed
- A comment for field `page_size` in message `.google.cloud.geminidataanalytics.v1beta.ListMessagesRequest` is changed
- A comment for field `project` in message `.google.cloud.geminidataanalytics.v1beta.ChatRequest` is changed
- A comment for field `credentials` in message `.google.cloud.geminidataanalytics.v1beta.DataAgentContext` is changed
- A comment for message `SystemMessage` is changed
- A comment for field `clarification` in message `.google.cloud.geminidataanalytics.v1beta.SystemMessage` is changed
- A comment for field `generated_looker_query` in message `.google.cloud.geminidataanalytics.v1beta.DataMessage` is changed
- A comment for message `ClarificationQuestion` is changed
- A comment for enum `SelectionMode` is changed
- A comment for enum value `SELECTION_MODE_UNSPECIFIED` in enum `SelectionMode` is changed
- A comment for enum value `SINGLE_SELECT` in enum `SelectionMode` is changed
- A comment for enum value `MULTI_SELECT` in enum `SelectionMode` is changed
- A comment for enum `ClarificationQuestionType` is changed
- A comment for enum value `CLARIFICATION_QUESTION_TYPE_UNSPECIFIED` in enum `ClarificationQuestionType` is changed
- A comment for enum value `FILTER_VALUES` in enum `ClarificationQuestionType` is changed
- A comment for enum value `FIELDS` in enum `ClarificationQuestionType` is changed
- A comment for field `question` in message `.google.cloud.geminidataanalytics.v1beta.ClarificationQuestion` is changed
- A comment for field `selection_mode` in message `.google.cloud.geminidataanalytics.v1beta.ClarificationQuestion` is changed
- A comment for field `options` in message `.google.cloud.geminidataanalytics.v1beta.ClarificationQuestion` is changed
- A comment for field `clarification_question_type` in message `.google.cloud.geminidataanalytics.v1beta.ClarificationQuestion` is changed
- A comment for message `ClarificationMessage` is changed
- A comment for field `questions` in message `.google.cloud.geminidataanalytics.v1beta.ClarificationMessage` is changed
- A comment for message `BigQueryTableReferences` is changed
- A comment for field `studio_references` in message `.google.cloud.geminidataanalytics.v1beta.StudioDatasourceReferences` is changed
- A comment for field `credentials` in message `.google.cloud.geminidataanalytics.v1beta.LookerExploreReferences` is changed
- A comment for field `category` in message `.google.cloud.geminidataanalytics.v1beta.Field` is changed

## Version 1.0.0-beta09, released 2026-03-16

### New features

- Add `ParameterizedSecureViewParameters` message and field for PSV support
- Add `ThinkingMode` enum and field to control agent thinking mode

### Documentation improvements

- Update field comments for `generated_looker_query` in `DataMessage`

## Version 1.0.0-beta08, released 2026-02-02

### New features

- Add ClarificationMessage, thought-signature, formatted-data

### Documentation improvements

- A comment for enum value THOUGHT in enum TextType is changed

## Version 1.0.0-beta07, released 2026-01-13

### New features

- Added sync APIs for the CRUD operations of Data Agent

## Version 1.0.0-beta06, released 2026-01-05

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

