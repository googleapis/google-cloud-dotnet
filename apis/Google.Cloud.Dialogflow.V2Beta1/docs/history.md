# Version history

## Version 1.0.0-beta21, released 2024-12-16

### New features

- Add new fields for delivering intermediate transcriptions through PubSub ([commit 82c1063](https://github.com/googleapis/google-cloud-dotnet/commit/82c10635d9faad47a724e503f4e8658c25e2b486))

## Version 1.0.0-beta20, released 2024-12-06

### New features

- Make TrainingPhrase name field output-only ([commit 0436b0d](https://github.com/googleapis/google-cloud-dotnet/commit/0436b0df581bee719f71512c5913c1f38026d47b))

## Version 1.0.0-beta19, released 2024-11-18

### New features

- Add options of query_source, search_config, end_user_metadata and exact_search ([commit 5c57238](https://github.com/googleapis/google-cloud-dotnet/commit/5c5723801ab467482cdeb0a0302ddb963da21c07))
- Expose metadata in AnswerSource ([commit 5c57238](https://github.com/googleapis/google-cloud-dotnet/commit/5c5723801ab467482cdeb0a0302ddb963da21c07))
- Added support for ALAW encoding ([commit 8b8a0d4](https://github.com/googleapis/google-cloud-dotnet/commit/8b8a0d4046b9f82d0ad20d3031f571dd0c463c44))
- Add options of query_source, search_config and context_size ([commit 8b8a0d4](https://github.com/googleapis/google-cloud-dotnet/commit/8b8a0d4046b9f82d0ad20d3031f571dd0c463c44))
- Add SipTrunks service ([commit 8b8a0d4](https://github.com/googleapis/google-cloud-dotnet/commit/8b8a0d4046b9f82d0ad20d3031f571dd0c463c44))

## Version 1.0.0-beta18, released 2024-08-05

### Bug fixes

- An existing method_signature `parent` is fixed for method `BatchCreateMessages` in service `Conversations` ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- Changed field behavior for an existing field `parent` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- Changed field behavior for an existing field `session_id` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))

### New features

- Add Proactive Generative Knowledge Assist endpoints and types ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- Add Generator related services and types ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- Add GenerateStatelessSuggestion related endpoints and types ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))

### Documentation improvements

- A comment for field `name` in message `.google.cloud.dialogflow.v2beta1.Conversation` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `conversation_stage` in message `.google.cloud.dialogflow.v2beta1.Conversation` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `filter` in message `.google.cloud.dialogflow.v2beta1.ListConversationsRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `latest_message` in message `.google.cloud.dialogflow.v2beta1.SuggestConversationSummaryRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `context_size` in message `.google.cloud.dialogflow.v2beta1.SuggestConversationSummaryRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `assist_query_params` in message `.google.cloud.dialogflow.v2beta1.SuggestConversationSummaryRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `latest_message` in message `.google.cloud.dialogflow.v2beta1.GenerateStatelessSummaryRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `max_context_size` in message `.google.cloud.dialogflow.v2beta1.GenerateStatelessSummaryRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `parent` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `session_id` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `conversation` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `latest_message` in message `.google.cloud.dialogflow.v2beta1.SearchKnowledgeRequest` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for message `HumanAgentHandoffConfig` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `live_person_config` in message `.google.cloud.dialogflow.v2beta1.HumanAgentHandoffConfig` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))
- A comment for field `audio` in message `.google.cloud.dialogflow.v2beta1.AudioInput` is changed ([commit 33eca8a](https://github.com/googleapis/google-cloud-dotnet/commit/33eca8af540108582435bd8cf0e2ec5230ab3430))

## Version 1.0.0-beta17, released 2024-06-04

### New features

- Add properties for nested resource name references ([commit 15eec4d](https://github.com/googleapis/google-cloud-dotnet/commit/15eec4dabb9fd3cf3b8f4b978d64b7ba435ca995))

## Version 1.0.0-beta16, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta15, released 2024-03-26

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 82bea85](https://github.com/googleapis/google-cloud-dotnet/commit/82bea850661975b9750ac30753528cc9d2e05240))

## Version 1.0.0-beta14, released 2024-03-21

### New features

- Added text sections to the submitted summary ([commit b036872](https://github.com/googleapis/google-cloud-dotnet/commit/b0368725f22b282abd78dcc39c1c8205d6be7594))
- Added conformer model migration opt out flag ([commit b036872](https://github.com/googleapis/google-cloud-dotnet/commit/b0368725f22b282abd78dcc39c1c8205d6be7594))
- Added intent input to StreamingAnalyzeContentRequest ([commit b036872](https://github.com/googleapis/google-cloud-dotnet/commit/b0368725f22b282abd78dcc39c1c8205d6be7594))

### Documentation improvements

- Clarified wording around END_OF_SINGLE_UTTERANCE ([commit b036872](https://github.com/googleapis/google-cloud-dotnet/commit/b0368725f22b282abd78dcc39c1c8205d6be7594))

## Version 1.0.0-beta13, released 2024-02-28

No API surface changes; just dependency updates.

## Version 1.0.0-beta12, released 2024-01-08

### New features

- Add sections field to HumanAgentAssistantConfig.SuggestionQueryConfig ([commit 24ff4e8](https://github.com/googleapis/google-cloud-dotnet/commit/24ff4e8af3383fdeec936b4b48cb883af3e3ed13))
- Add enable_conversation_augmented_query field to HumanAgentAssistantConfig.SuggestionFeatureConfig message ([commit 24ff4e8](https://github.com/googleapis/google-cloud-dotnet/commit/24ff4e8af3383fdeec936b4b48cb883af3e3ed13))
- Add INTENT enum in SearchKnowledgeAnswer.AnswerType message ([commit 24ff4e8](https://github.com/googleapis/google-cloud-dotnet/commit/24ff4e8af3383fdeec936b4b48cb883af3e3ed13))
- Add rewritten_query in field in SearchKnowledgeResponse message ([commit 24ff4e8](https://github.com/googleapis/google-cloud-dotnet/commit/24ff4e8af3383fdeec936b4b48cb883af3e3ed13))

### Documentation improvements

- Improved comments on audio_config proto ([commit 24ff4e8](https://github.com/googleapis/google-cloud-dotnet/commit/24ff4e8af3383fdeec936b4b48cb883af3e3ed13))

## Version 1.0.0-beta11, released 2023-10-02

### New features

- Add the enable_extended_streaming flag ([commit 68ba677](https://github.com/googleapis/google-cloud-dotnet/commit/68ba67718434f26f89829706f77c2297bb2a3f5d))
- Remove backend API deadline ([commit 68ba677](https://github.com/googleapis/google-cloud-dotnet/commit/68ba67718434f26f89829706f77c2297bb2a3f5d))

## Version 1.0.0-beta10, released 2023-09-06

### New features

- Added speech endpointing setting ([commit d275b98](https://github.com/googleapis/google-cloud-dotnet/commit/d275b989c2bb0476bf61c1cb4dbda9a1814dbd2f))
- Added Knowledge Search API ([commit d275b98](https://github.com/googleapis/google-cloud-dotnet/commit/d275b989c2bb0476bf61c1cb4dbda9a1814dbd2f))

## Version 1.0.0-beta09, released 2023-08-16

### New features

- Added baseline model version used to generate the summary ([commit db55ecf](https://github.com/googleapis/google-cloud-dotnet/commit/db55ecf0dc70331dcc0885b5849a2fd5165328e8))
- Added the platform of the virtual agent response messages ([commit db55ecf](https://github.com/googleapis/google-cloud-dotnet/commit/db55ecf0dc70331dcc0885b5849a2fd5165328e8))

### Documentation improvements

- Minor formatting ([commit e039489](https://github.com/googleapis/google-cloud-dotnet/commit/e03948944646ea027acf56b9a7e5ab90b30ed080))
- Added google.api.field_behavior for some fields in audio_config ([commit 9879eda](https://github.com/googleapis/google-cloud-dotnet/commit/9879edadbc53be074b59841a56a99a40d1275eeb))

## Version 1.0.0-beta08, released 2023-06-27

### New features

- Added dialogflow_assist_answer ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))
- Added session_ttl ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))
- Added human_agent_side_config ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))
- Added suggestion_input ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))
- Added suggest_dialogflow_assists_response ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))
- Added suggest_entity_extraction_response ([commit 7608b18](https://github.com/googleapis/google-cloud-dotnet/commit/7608b18b56280b3812fc12fd1569f7531df3a164))

## Version 1.0.0-beta07, released 2023-05-11

### New features

- Add baseline model configuration for conversation summarization ([commit e2bfd58](https://github.com/googleapis/google-cloud-dotnet/commit/e2bfd583a2afbd2873ceadeb7fb4abf8ff87fb1a))
- Extended StreamingListCallCompanionEvents timeout to 600 seconds ([commit 395fbd9](https://github.com/googleapis/google-cloud-dotnet/commit/395fbd912b89199e247ea905047f17aaf904bdae))
- Added debug info for StreamingDetectIntent ([commit 395fbd9](https://github.com/googleapis/google-cloud-dotnet/commit/395fbd912b89199e247ea905047f17aaf904bdae))
- Added GenerateStatelessSummary method ([commit 395fbd9](https://github.com/googleapis/google-cloud-dotnet/commit/395fbd912b89199e247ea905047f17aaf904bdae))

## Version 1.0.0-beta06, released 2023-03-06

### New features

- Added support for custom content types ([commit 88cc1eb](https://github.com/googleapis/google-cloud-dotnet/commit/88cc1eb787ff1e355ae57feb38ad641c45a90035))

### Documentation improvements

- Clarified wording around quota usage ([commit 88cc1eb](https://github.com/googleapis/google-cloud-dotnet/commit/88cc1eb787ff1e355ae57feb38ad641c45a90035))

## Version 1.0.0-beta05, released 2023-02-22

### New features

- Add PhraseSetName resource name ([commit 4a33a31](https://github.com/googleapis/google-cloud-dotnet/commit/4a33a31648f1fcdcd0e249c0566d641ebd3d8271))

## Version 1.0.0-beta04, released 2023-01-20

### New features

- Enable REST transport ([commit 46d4fe8](https://github.com/googleapis/google-cloud-dotnet/commit/46d4fe8461ac30e7666600e44e7bd16228768621))

## Version 1.0.0-beta03, released 2022-12-14

### New features

- Added cx_current_page field to AutomatedAgentReply ([commit bdd8fb5](https://github.com/googleapis/google-cloud-dotnet/commit/bdd8fb514ebbee57c57b9770f101e132b60efded))

### Documentation improvements

- Clarified docs for Sentiment ([commit bdd8fb5](https://github.com/googleapis/google-cloud-dotnet/commit/bdd8fb514ebbee57c57b9770f101e132b60efded))

## Version 1.0.0-beta02, released 2022-10-03

### New features

- Add Agent Assist Summarization API (https://cloud.google.com/agent-assist/docs/summarization) ([commit 702ea24](https://github.com/googleapis/google-cloud-dotnet/commit/702ea2455ea4829f2e3e8d1158774fd53ea8af74))

### Documentation improvements

- Clarify SuggestionFeature enums which are specific to chat agents ([commit 702ea24](https://github.com/googleapis/google-cloud-dotnet/commit/702ea2455ea4829f2e3e8d1158774fd53ea8af74))

## Version 1.0.0-beta01, released 2022-08-31

Initial release.
