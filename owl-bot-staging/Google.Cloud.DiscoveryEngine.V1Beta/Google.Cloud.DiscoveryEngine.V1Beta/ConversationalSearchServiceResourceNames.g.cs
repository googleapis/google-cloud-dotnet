// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class ConverseConversationRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServingConfigName"/>-typed view over the <see cref="ServingConfig"/> resource name property.
        /// </summary>
        public ServingConfigName ServingConfigAsServingConfigName
        {
            get => string.IsNullOrEmpty(ServingConfig) ? null : ServingConfigName.Parse(ServingConfig, allowUnparsed: true);
            set => ServingConfig = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversationRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConversationRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetConversationRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConversationsRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AnswerQueryRequest
    {
        /// <summary>
        /// <see cref="ServingConfigName"/>-typed view over the <see cref="ServingConfig"/> resource name property.
        /// </summary>
        public ServingConfigName ServingConfigAsServingConfigName
        {
            get => string.IsNullOrEmpty(ServingConfig) ? null : ServingConfigName.Parse(ServingConfig, allowUnparsed: true);
            set => ServingConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SearchSpec
            {
                public partial class Types
                {
                    public partial class SearchResultList
                    {
                        public partial class Types
                        {
                            public partial class SearchResult
                            {
                                public partial class Types
                                {
                                    public partial class UnstructuredDocumentInfo
                                    {
                                        /// <summary>
                                        /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/>
                                        /// resource name property.
                                        /// </summary>
                                        public DocumentName DocumentAsDocumentName
                                        {
                                            get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
                                            set => Document = value?.ToString() ?? "";
                                        }
                                    }

                                    public partial class ChunkInfo
                                    {
                                        /// <summary>
                                        /// <see cref="ChunkName"/>-typed view over the <see cref="Chunk"/> resource
                                        /// name property.
                                        /// </summary>
                                        public ChunkName ChunkAsChunkName
                                        {
                                            get => string.IsNullOrEmpty(Chunk) ? null : ChunkName.Parse(Chunk, allowUnparsed: true);
                                            set => Chunk = value?.ToString() ?? "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public partial class GetAnswerRequest
    {
        /// <summary>
        /// <see cref="gcdv::AnswerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnswerName AnswerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnswerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSessionRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSessionRequest
    {
        /// <summary>
        /// <see cref="gcdv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSessionRequest
    {
        /// <summary>
        /// <see cref="gcdv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSessionsRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
