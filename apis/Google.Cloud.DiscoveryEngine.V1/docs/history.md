# Version history

## Version 1.9.0, released 2025-07-28

### New features

- Add SessionService
- Add AssistantService

### Documentation improvements

- A comment for field `filter` in message `.google.cloud.discoveryengine.v1.ListSessionsRequest` is changed
- A comment for field `session` in message `.google.cloud.discoveryengine.v1.SearchRequest` is changed
- A comment for field `query` in message `.google.cloud.discoveryengine.v1.Session` is changed
- A comment for field `answer` in message `.google.cloud.discoveryengine.v1.Session` is changed
- A comment for field `query_id` in message `.google.cloud.discoveryengine.v1.Query` is changed

## Version 1.8.0, released 2025-06-09

### New features

- Add CMEK config service
- Add identity mapping service
- Add user license config service
- Add HealthcareFhirConfig to FHIR data store
- Add ConnectorRunErrorContext to error log
- Support structured content for chunk
- Support ACL data store and document
- Add more options for layout parser config
- Support media recommendation engine
- Enable claim level score for grounding
- Add custom search operators for Workspace search
- Add more indexing state for site search engine

### Documentation improvements

- Keep the API doc up-to-date with recent changes

## Version 1.7.0, released 2025-03-31

### New features

- Move serving config update API to GA ([commit 6ab720b](https://github.com/googleapis/google-cloud-dotnet/commit/6ab720b899be56321d4b368fc73bc0a519ac6bad))
- Add time_zone in user info ([commit 6ab720b](https://github.com/googleapis/google-cloud-dotnet/commit/6ab720b899be56321d4b368fc73bc0a519ac6bad))
- Add stream answer API ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support query rephraser model for answer API ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support end user spec for answer API ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support grounding and safety rating for answer API ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support relevance threshold in search ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support boosting for blended search ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support auto mode in search as your type ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support model scores in search ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support search highlighting ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support enterprise web retrieval source for grounding ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support images in web search grounding ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Add sitemap APIs ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Add interpolation boost action and promotion action ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Allow FHIR import to use latest predefined schema ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Allow unstructured data import to force refresh all content ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support conversion user event ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))
- Support panel aware user event ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 6ab720b](https://github.com/googleapis/google-cloud-dotnet/commit/6ab720b899be56321d4b368fc73bc0a519ac6bad))
- Keep the API doc up-to-date with recent changes ([commit 6cc15c4](https://github.com/googleapis/google-cloud-dotnet/commit/6cc15c4ca3085a1d7d002ea1a50140e1e9b1973a))

## Version 1.6.0, released 2024-10-29

### New features

- Add lite search API to allow public website search with API key ([commit bfc1d53](https://github.com/googleapis/google-cloud-dotnet/commit/bfc1d5353befef905905f145e1c0048ee09f0743))
- Add LOW_GROUNDED_ANSWER in answer skip reasons ([commit bfc1d53](https://github.com/googleapis/google-cloud-dotnet/commit/bfc1d5353befef905905f145e1c0048ee09f0743))
- Support query regex in control match rules ([commit bfc1d53](https://github.com/googleapis/google-cloud-dotnet/commit/bfc1d5353befef905905f145e1c0048ee09f0743))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit bfc1d53](https://github.com/googleapis/google-cloud-dotnet/commit/bfc1d5353befef905905f145e1c0048ee09f0743))

## Version 1.5.0, released 2024-10-14

### New features

- Add GroundedGenerationService API ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))
- Add BillingEstimation in data store ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))
- Support Google Workspace search ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))
- Support advanced boost search ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))
- Add one_box_page_size on search ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))
- Add site_credential for site search config ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))

### Documentation improvements

- Update documentation ([commit 0e8e0e2](https://github.com/googleapis/google-cloud-dotnet/commit/0e8e0e2638e4759dcc4d2b98bc1f1b88f236666c))

## Version 1.4.0, released 2024-09-09

### New features

- Promote search tuning service to v1 ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Promot user event purge to v1 ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Return structured document info in answers ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Return index status in document ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Support batch documents purge with GCS input ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Support batch get documents metadata by uri patterns ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))
- Return joined status in user event ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit a266c61](https://github.com/googleapis/google-cloud-dotnet/commit/a266c618438f66605485d54ad99066eb19825107))

## Version 1.3.0, released 2024-07-08

### New features

- Add Chunk resource in the search response ([commit f45a47f](https://github.com/googleapis/google-cloud-dotnet/commit/f45a47fdbd58cbff8349ba7f0d9975bee8cf55a2))
- Add NO_RELEVANT_CONTENT to Answer API ([commit f45a47f](https://github.com/googleapis/google-cloud-dotnet/commit/f45a47fdbd58cbff8349ba7f0d9975bee8cf55a2))
- Support AlloyDB Connector ([commit f45a47f](https://github.com/googleapis/google-cloud-dotnet/commit/f45a47fdbd58cbff8349ba7f0d9975bee8cf55a2))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit f45a47f](https://github.com/googleapis/google-cloud-dotnet/commit/f45a47fdbd58cbff8349ba7f0d9975bee8cf55a2))

## Version 1.2.0, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.1.0, released 2024-05-30

### New features

- Support multiple parent patterns for controls ([commit c8f3726](https://github.com/googleapis/google-cloud-dotnet/commit/c8f3726962a03da080d343eaceb78c50b553cf2c))
- Promote grounding check APIs to v1 GA ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))
- Promote answer APIs to v1 GA ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))
- Promote ranking APIs to v1 GA ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))
- Add control service APIs ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))
- Support writing user events for blended engines ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))
- Support cancelling import operations ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))

### Documentation improvements

- Mention multiple parent patterns for controls ([commit c8f3726](https://github.com/googleapis/google-cloud-dotnet/commit/c8f3726962a03da080d343eaceb78c50b553cf2c))
- Keep the API doc up-to-date with recent changes ([commit 8e6674a](https://github.com/googleapis/google-cloud-dotnet/commit/8e6674ae0022eaa489693ac842f0c104addd316a))

## Version 1.0.0, released 2024-05-24

No API surface changes; just dependency updates and promotion to GA.

## Version 1.0.0-beta06, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta05, released 2024-04-19

### New features

- Promote recommendation service to v1 ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))
- Promote blending search to v1 ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))
- Promote healthcare search to v1 ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))
- Promote online chunking search to v1 ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))
- Support import data from Cloud Spanner, BigTable, SQL and Firestore ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))
- Support boost/bury on multi-turn search ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 1c69086](https://github.com/googleapis/google-cloud-dotnet/commit/1c69086ce35ba32d5e2b242f05cda05df5c19ded))

## Version 1.0.0-beta04, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta03, released 2024-03-13

No API surface changes; just dependency updates.

## Version 1.0.0-beta02, released 2024-02-09

### New features

- Add data store, engine and site search engine services ([commit 2125414](https://github.com/googleapis/google-cloud-dotnet/commit/212541441f8a7eb5b211f7510d7c63589ba33aeb))
- Support search summarization with citations and references ([commit 2125414](https://github.com/googleapis/google-cloud-dotnet/commit/212541441f8a7eb5b211f7510d7c63589ba33aeb))
- Add suggestion deny list import/purge APIs ([commit 2125414](https://github.com/googleapis/google-cloud-dotnet/commit/212541441f8a7eb5b211f7510d7c63589ba33aeb))
- Add engine support for multi-turn search and search APIs ([commit 2125414](https://github.com/googleapis/google-cloud-dotnet/commit/212541441f8a7eb5b211f7510d7c63589ba33aeb))

### Documentation improvements

- Keep the API doc up-to-date with recent changes ([commit 2125414](https://github.com/googleapis/google-cloud-dotnet/commit/212541441f8a7eb5b211f7510d7c63589ba33aeb))

## Version 1.0.0-beta01, released 2023-09-08

Initial release.
